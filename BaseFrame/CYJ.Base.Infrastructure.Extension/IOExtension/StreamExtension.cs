using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace CYJ.Utils.Extension.IOExtension
{
    public static class StreamExtension
    {
        /// <summary>
        ///     将流读到末尾并返回读取到的内容
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>
        ///     The rest of the stream as a string, from the current position to the end. If the current position is at the
        ///     end of the stream, returns an empty string ("").
        /// </returns>
        public static string ReadToEnd(this Stream @this)
        {
            using (var sr = new StreamReader(@this, Encoding.Default))
            {
                return sr.ReadToEnd();
            }
        }

        /// <summary>
        ///     将流读到末尾并返回读取到的内容
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="encoding">The encoding.</param>
        /// <returns>
        ///     The rest of the stream as a string, from the current position to the end. If the current position is at the
        ///     end of the stream, returns an empty string ("").
        /// </returns>
        public static string ReadToEnd(this Stream @this, Encoding encoding)
        {
            using (var sr = new StreamReader(@this, encoding))
            {
                return sr.ReadToEnd();
            }
        }

        /// <summary>
        ///     将流读到末尾并返回读取到的内容
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="position">The position.</param>
        /// <returns>
        ///     The rest of the stream as a string, from the current position to the end. If the current position is at the
        ///     end of the stream, returns an empty string ("").
        /// </returns>
        public static string ReadToEnd(this Stream @this, long position)
        {
            @this.Position = position;

            using (var sr = new StreamReader(@this, Encoding.Default))
            {
                return sr.ReadToEnd();
            }
        }

        /// <summary>
        ///    将流读到末尾并返回读取到的内容
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="encoding">The encoding.</param>
        /// <param name="position">The position.</param>
        /// <returns>
        ///     The rest of the stream as a string, from the current position to the end. If the current position is at the
        ///     end of the stream, returns an empty string ("").
        /// </returns>
        public static string ReadToEnd(this Stream @this, Encoding encoding, long position)
        {
            @this.Position = position;

            using (var sr = new StreamReader(@this, encoding))
            {
                return sr.ReadToEnd();
            }
        }

        /// <summary>
        ///    转换流为字节数组
        /// </summary>
        /// <param name="this">The Stream to act on.</param>
        /// <returns>The Stream as a byte[].</returns>
        public static byte[] ToByteArray(this Stream @this)
        {
            using (var ms = new MemoryStream())
            {
                @this.CopyTo(ms);
                return ms.ToArray();
            }
        }

        /// <summary>
        ///     获取流的Md5
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>@this as a string.</returns>
        public static string GetMd5Hash(this Stream @this)
        {
            using (var md5 = MD5.Create())
            {
                var hashBytes = md5.ComputeHash(@this);
                var sb = new StringBuilder();
                foreach (var bytes in hashBytes) sb.Append(bytes.ToString("X2"));

                return sb.ToString();
            }
        }
    }
}