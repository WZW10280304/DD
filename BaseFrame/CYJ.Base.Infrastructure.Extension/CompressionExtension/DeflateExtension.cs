using System.IO;
using System.IO.Compression;

// ReSharper disable once CheckNamespace
namespace Aquarium.Util.Extension.CompressionExtension
{
    public static class DeflateExtension
    {
        #region Deflate

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bytes"></param>
        /// <param name="invokType"></param>
        /// <returns></returns>
        private static byte[] DeflateBytes(this byte[] bytes, CompressionMode invokType = CompressionMode.Compress)
        {
            if (bytes == null) return null;
            if (invokType == CompressionMode.Compress)
                using (var output = new MemoryStream())
                {
                    using (
                        var compressor = new DeflateStream(
                            output, invokType))
                    {
                        compressor.Write(bytes, 0, bytes.Length);
                    }

                    return output.ToArray();
                }
            else
                using (var output = new MemoryStream())
                {
                    using (var ms = new MemoryStream(bytes) {Position = 0})
                    {
                        using (
                            var compressor = new DeflateStream(ms, invokType))
                        {
                            var buf = new byte[1024];
                            int len;
                            while ((len = compressor.Read(buf, 0, buf.Length)) > 0)
                                output.Write(buf, 0, len);
                        }
                    }

                    return output.ToArray();
                }
        }

        /// <summary>
        ///     使用Deflate压缩算法解压缩字节
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public static byte[] DecompressDeflate(this byte[] bytes)
        {
            return bytes.DeflateBytes(CompressionMode.Decompress);
        }

        /// <summary>
        ///     使用Deflate压缩算法压缩字节
        /// </summary>
        /// <param name="bytes">要压缩的字节</param>
        /// <returns>压缩后的字节</returns>
        public static byte[] CompressDeflate(this byte[] bytes)
        {
            return bytes.DeflateBytes();
        }

        #endregion Deflate
    }
}