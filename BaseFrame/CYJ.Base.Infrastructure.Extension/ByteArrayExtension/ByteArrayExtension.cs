using System.IO;
using System.Text;
using CYJ.Utils.Extension.LinqExtension;

// ReSharper disable once CheckNamespace
namespace Aquarium.Util.Extension.ByteArrayExtension
{
    public static class ByteArrayExtension
    {
        /// <summary>
        ///    将byte[]转换成string(指定Encoding)
        /// </summary>
        /// <param name="bytes">要转换的字节</param>
        /// <param name="encoding">转换的编码，默认为Encoding.Default</param>
        /// <returns>转换后的字符串</returns>
        public static string ToString(this byte[] bytes, Encoding encoding = null)
        {
            if (EnumerableExtension.IsNullOrEmpty(bytes)) return null;
            return encoding != null ? encoding.GetString(bytes) : Encoding.Default.GetString(bytes);
        }



        /// <summary>
        ///     将字节转换成流
        /// </summary>
        /// <param name="bytes">要准换的字节</param>
        /// <returns>转换后的流</returns>
        public static Stream ToStream(this byte[] bytes)
        {
            return new MemoryStream(bytes);
        }
    }
}