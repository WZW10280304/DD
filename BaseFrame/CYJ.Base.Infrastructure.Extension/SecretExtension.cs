using System;
using System.Globalization;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace CYJ.Utils.Extension
{
    /// <summary>
    ///     加密扩展类
    /// </summary>
// ReSharper disable once CheckNamespace
    public static class SecretExtension
    {
        #region MD5

        /// <summary>
        ///     Md5加密
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string GetMd5(this string str)
        {
            var md5Hasher = MD5.Create();
            var data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(str));
            var sBuilder = new StringBuilder();
            foreach (var t in data) sBuilder.Append(t.ToString("x2"));
            return sBuilder.ToString();
        }

        #endregion

        #region SHA1加密

        /// <summary>
        ///     SHA1加密
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string GetSha1(this string str)
        {
            var strRes = str.GetSha1Bytes();
            var enText = new StringBuilder();
            foreach (var iByte in strRes) enText.AppendFormat("{0:x2}", iByte);
            return enText.ToString();
        }

        /// <summary>
        ///     SHA1加密字节
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static byte[] GetSha1Bytes(this string str)
        {
            SHA1 sha = new SHA1CryptoServiceProvider();
            var dataToHash = Encoding.Default.GetBytes(str);
            return sha.ComputeHash(dataToHash);
        }

        #endregion

        #region Rsa

        /// <summary>
        ///     A string extension method that encrypts the string.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="key">The key.</param>
        /// <returns>The encrypted string.</returns>
        public static string GetEncryptRsa(this string @this, string key)
        {
            var cspp = new CspParameters {KeyContainerName = key};
            var rsa = new RSACryptoServiceProvider(cspp) {PersistKeyInCsp = true};
            var bytes = rsa.Encrypt(Encoding.UTF8.GetBytes(@this), true);

            return BitConverter.ToString(bytes);
        }

        /// <summary>
        ///     A string extension method that decrypt a string.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="key">The key.</param>
        /// <returns>The decrypted string.</returns>
        public static string GetDecryptRsa(this string @this, string key)
        {
            var cspp = new CspParameters {KeyContainerName = key};
            var rsa = new RSACryptoServiceProvider(cspp) {PersistKeyInCsp = true};
            var decryptArray = @this.Split(new[] {"-"}, StringSplitOptions.None);
            var decryptByteArray =
                Array.ConvertAll(decryptArray, s => Convert.ToByte(byte.Parse(s, NumberStyles.HexNumber)));
            var bytes = rsa.Decrypt(decryptByteArray, true);

            return Encoding.UTF8.GetString(bytes);
        }

        #endregion

        #region AES加密、解密

        private const string Key = "cTyonq4NFpXmssau+TDV7btLUuhDxBGF1Jysk";

        private static RijndaelManaged Create(string key, string iv)
        {
            var rm = new RijndaelManaged
            {
                Key = Encoding.UTF8.GetBytes(key),
                IV = Encoding.UTF8.GetBytes(iv),
                Mode = CipherMode.CBC,
                Padding = PaddingMode.PKCS7
            };
            // 这里统一使用UTF8进行编码；
            // 如果使用其它编码，要注意长度问题；
            return rm;
        }

        private static byte[] Encryptor(byte[] bs, string key, string iv)
        {
            var transform = Create(key, iv).CreateEncryptor();
            return transform.TransformFinalBlock(bs, 0, bs.Length);
        }

        private static byte[] Decryptor(byte[] bs, string key, string iv)
        {
            var transform = Create(key, iv).CreateDecryptor();
            return transform.TransformFinalBlock(bs, 0, bs.Length);
        }

        private static byte[] Simple(bool encrypt, byte[] bs, string password)
        {
            // 借用 MD5 算法，将密码统一为32位长度字符串
            var md5 = new StringBuilder();
            foreach (var b in MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(password))) md5.Append(b.ToString("X2"));

            // KEY 为 MD5
            var key = md5.ToString();

            // IV 为 MD5 中截取中间的16位字符
            var iv = key.Substring(8, 16);

            // 根据是否加密 调用不同的方法
            return encrypt ? Encryptor(bs, key, iv) : Decryptor(bs, key, iv);
        }

        /// <summary>
        ///     AES256加密方法>加密（true），解密（false）
        /// </summary>
        /// <param name="encrypt">加密（true），解密（false）</param>
        /// <param name="str">加密解密字符串</param>
        /// <param name="password">加急解密密钥</param>
        /// <returns>加密结果</returns>
        private static string Simple(bool encrypt, string str, string password)
        {
            if (!encrypt)
                try
                {
                    var bs = GetHexBytes(str);
                    var b = Simple(false, bs, password);
                    return Encoding.UTF8.GetString(b);
                }
                catch (Exception)
                {
                    return "Decryption failure！";
                }

            var bs2 = Encoding.UTF8.GetBytes(str);
            var b2 = Simple(true, bs2, password);
            return GetHexString(b2);
        }

        /// <summary>
        ///     加密
        /// </summary>
        /// <param name="companyValidCode"></param>
        /// <returns></returns>
        public static string GetEncryptByAes(this string companyValidCode)
        {
            return Simple(true, companyValidCode, Key);
        }

        /// <summary>
        ///     解密
        /// </summary>
        /// <param name="companyValidCode"></param>
        /// <returns></returns>
        public static string GetDecryptByAes(this string companyValidCode)
        {
            if (string.IsNullOrEmpty(companyValidCode) || companyValidCode.Trim().Trim().Length == 0) return "";
            return Simple(false, companyValidCode, Key);
        }

        public static string GetHexString(this byte[] bytes) // 0xae00cf => "AE00CF "
        {
            try
            {
                var hexString = string.Empty;
                if (bytes == null) return hexString;
                var strB = new StringBuilder();
                foreach (var t in bytes) strB.Append(t.ToString("X2"));
                hexString = strB.ToString();
                return hexString;
            }
            catch
            {
                return null;
            }
        }

        public static byte[] GetHexBytes(this string hexString)
        {
            var returnBytes = new byte[hexString.Length / 2];
            for (var i = 0; i < returnBytes.Length; i++)
                returnBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
            return returnBytes;
        }

        #endregion AES加密、解密

        #region Des加密、解密

        //默认密钥向量
        private static readonly byte[] Keys = {0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF};

        /// <summary>
        ///     Des加密
        /// </summary>
        /// <param name="encryptString"></param>
        /// <param name="encryptKey"></param>
        /// <returns></returns>
        public static string GetEncryptDes(this string encryptString, string encryptKey)
        {
            try
            {
                var rgbKey = Encoding.UTF8.GetBytes(encryptKey.Substring(0, 8));
                var rgbIv = Keys;
                var inputByteArray = Encoding.UTF8.GetBytes(encryptString);
                var dCsp = new DESCryptoServiceProvider();
                var mStream = new MemoryStream();
                var cStream = new CryptoStream(mStream, dCsp.CreateEncryptor(rgbKey, rgbIv), CryptoStreamMode.Write);
                cStream.Write(inputByteArray, 0, inputByteArray.Length);
                cStream.FlushFinalBlock();
                return Convert.ToBase64String(mStream.ToArray());
            }
            catch
            {
                return encryptString;
            }
        }

        /// <summary>
        ///     des解密
        /// </summary>
        /// <param name="decryptString"></param>
        /// <param name="decryptKey"></param>
        /// <returns></returns>
        public static string GetDecryptDes(this string decryptString, string decryptKey)
        {
            try
            {
                var rgbKey = Encoding.UTF8.GetBytes(decryptKey.Substring(0, 8));
                var rgbIv = Keys;
                var inputByteArray = Convert.FromBase64String(decryptString);
                var dcsp = new DESCryptoServiceProvider();
                var mStream = new MemoryStream();
                var cStream = new CryptoStream(mStream, dcsp.CreateDecryptor(rgbKey, rgbIv), CryptoStreamMode.Write);
                cStream.Write(inputByteArray, 0, inputByteArray.Length);
                cStream.FlushFinalBlock();
                return Encoding.UTF8.GetString(mStream.ToArray());
            }
            catch
            {
                return decryptString;
            }
        }

        #endregion Des加密、解密

        #region 吴晶加密法

        /// <summary>
        ///     对号码进行加密
        /// </summary>
        /// <param name="context">手机号</param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetHideSpecialString(this string context, string key = "Gt8658")
        {
            try
            {
                if (context.Length <= 1) return string.Empty;
                var lastChar = context.Substring(context.Length - 1, 1);
                var keyStrBuilder = new StringBuilder();
                foreach (var b in Encoding.UTF8.GetBytes(key.ToCharArray())) keyStrBuilder.Append(b.ToString());

                var result = new StringBuilder();
                foreach (var b in Encoding.UTF8.GetBytes(context.ToCharArray())) result.Append(b.ToString());

                return lastChar + keyStrBuilder + result;
            }
            catch
            {
                throw new Exception("手机号码加密失败");
            }

            //return context;
        }

        /// <summary>
        ///     对手机号进行解密
        /// </summary>
        /// <param name="context">手机号</param>
        /// <param name="num">默认为0</param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetShowSpecialString(this string context, int num = 0, string key = "Gt8658")
        {
            try
            {
                if (string.IsNullOrEmpty(context)) return string.Empty;
                if (context.Length <= 1) return string.Empty;
                context = context.Remove(0, 1);
                var keyStrBuilder = new StringBuilder();
                foreach (var b in Encoding.UTF8.GetBytes(key.ToCharArray())) keyStrBuilder.Append(b.ToString());
                context = context.Replace(keyStrBuilder.ToString(), "");

                var result = new StringBuilder();
                context = context.Substring(0, context.Length - num);
                context = context.Substring(num);
                var single = string.Empty;
                foreach (var b in context)
                {
                    single += b;
                    if (single.Length != 2) continue;
                    var asciiCode = int.Parse(single);
                    if (asciiCode < 0 || asciiCode > 255) continue;
                    var utf8Encoding = new UTF8Encoding();
                    var byteArray = new[] {(byte) asciiCode};
                    var strCharacter = utf8Encoding.GetString(byteArray);
                    result.Append(strCharacter);
                    single = string.Empty;
                }

                return result.ToString();
            }
            catch
            {
                return context;
            }
        }

        #endregion 吴晶加密法
    }
}