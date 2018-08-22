using System.IO;
using System.IO.Compression;
using System.Text;

// ReSharper disable once CheckNamespace
namespace Aquarium.Util.Extension.CompressionExtension
{
    public static class GZipExtension
    {
        #region Decompress

        /// <summary>
        ///     使用GZip压缩算法将字节数组解压到字符串中
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>The byte array gzip to string.</returns>
        public static string DecompressGZip(this byte[] @this)
        {
            const int bufferSize = 1024;
            using (var memoryStream = new MemoryStream(@this))
            {
                using (var zipStream = new GZipStream(memoryStream, CompressionMode.Decompress))
                {
                    // Memory stream for storing the decompressed bytes
                    using (var outStream = new MemoryStream())
                    {
                        var buffer = new byte[bufferSize];
                        var totalBytes = 0;
                        int readBytes;
                        while ((readBytes = zipStream.Read(buffer, 0, bufferSize)) > 0)
                        {
                            outStream.Write(buffer, 0, readBytes);
                            totalBytes += readBytes;
                        }

                        return Encoding.Default.GetString(outStream.GetBuffer(), 0, totalBytes);
                    }
                }
            }
        }

        /// <summary>
        ///     使用GZip压缩算法将字节数组解压到字符串中
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="encoding">The encoding.</param>
        /// <returns>The byte array gzip to string.</returns>
        public static string DecompressGZip(this byte[] @this, Encoding encoding)
        {
            const int bufferSize = 1024;
            using (var memoryStream = new MemoryStream(@this))
            {
                using (var zipStream = new GZipStream(memoryStream, CompressionMode.Decompress))
                {
                    // Memory stream for storing the decompressed bytes
                    using (var outStream = new MemoryStream())
                    {
                        var buffer = new byte[bufferSize];
                        var totalBytes = 0;
                        int readBytes;
                        while ((readBytes = zipStream.Read(buffer, 0, bufferSize)) > 0)
                        {
                            outStream.Write(buffer, 0, readBytes);
                            totalBytes += readBytes;
                        }

                        return encoding.GetString(outStream.GetBuffer(), 0, totalBytes);
                    }
                }
            }
        }

        #endregion

        #region CreateGZip

        /// <summary>
        ///     使用GZip压缩文件
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        public static void CreateGZip(this FileInfo @this)
        {
            using (var originalFileStream = @this.OpenRead())
            {
                using (var compressedFileStream = File.Create(@this.FullName + ".gz"))
                {
                    using (var compressionStream = new GZipStream(compressedFileStream, CompressionMode.Compress))
                    {
                        originalFileStream.CopyTo(compressionStream);
                    }
                }
            }
        }

        /// <summary>
        ///     使用GZip压缩文件
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="destination">Destination for the zip.</param>
        public static void CreateGZip(this FileInfo @this, string destination)
        {
            using (var originalFileStream = @this.OpenRead())
            {
                using (var compressedFileStream = File.Create(destination))
                {
                    using (var compressionStream = new GZipStream(compressedFileStream, CompressionMode.Compress))
                    {
                        originalFileStream.CopyTo(compressionStream);
                    }
                }
            }
        }

        /// <summary>
        ///     使用GZip压缩文件
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="destination">Destination for the zip.</param>
        public static void CreateGZip(this FileInfo @this, FileInfo destination)
        {
            using (var originalFileStream = @this.OpenRead())
            {
                using (var compressedFileStream = File.Create(destination.FullName))
                {
                    using (var compressionStream = new GZipStream(compressedFileStream, CompressionMode.Compress))
                    {
                        originalFileStream.CopyTo(compressionStream);
                    }
                }
            }
        }

        #endregion

        #region ExtractGZipToDirectory

        /// <summary>
        ///     创建GZip文件到指定目录
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        public static void ExtractGZipToDirectory(this FileInfo @this)
        {
            using (var originalFileStream = @this.OpenRead())
            {
                var newFileName = Path.GetFileNameWithoutExtension(@this.FullName);

                using (var decompressedFileStream = File.Create(newFileName))
                {
                    using (var decompressionStream = new GZipStream(originalFileStream, CompressionMode.Decompress))
                    {
                        decompressionStream.CopyTo(decompressedFileStream);
                    }
                }
            }
        }

        /// <summary>
        ///     创建GZip文件到指定目录
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="destination">Destination for the.</param>
        public static void ExtractGZipToDirectory(this FileInfo @this, string destination)
        {
            using (var originalFileStream = @this.OpenRead())
            {
                using (var compressedFileStream = File.Create(destination))
                {
                    using (var compressionStream = new GZipStream(compressedFileStream, CompressionMode.Compress))
                    {
                        originalFileStream.CopyTo(compressionStream);
                    }
                }
            }
        }

        /// <summary>
        ///     创建GZip文件到指定目录.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="destination">Destination for the.</param>
        public static void ExtractGZipToDirectory(this FileInfo @this, FileInfo destination)
        {
            using (var originalFileStream = @this.OpenRead())
            {
                using (var compressedFileStream = File.Create(destination.FullName))
                {
                    using (var compressionStream = new GZipStream(compressedFileStream, CompressionMode.Compress))
                    {
                        originalFileStream.CopyTo(compressionStream);
                    }
                }
            }
        }

        #endregion

        #region CompressGZip

        /// <summary>
        ///     将给定的字符串压缩为 GZip 字节数组。
        /// </summary>
        /// <param name="this">The stringToCompress to act on.</param>
        /// <returns>The string compressed into a GZip byte array.</returns>
        public static byte[] CompressGZip(this string @this)
        {
            var stringAsBytes = Encoding.Default.GetBytes(@this);
            using (var memoryStream = new MemoryStream())
            {
                using (var zipStream = new GZipStream(memoryStream, CompressionMode.Compress))
                {
                    zipStream.Write(stringAsBytes, 0, stringAsBytes.Length);
                    zipStream.Close();
                    return memoryStream.ToArray();
                }
            }
        }

        /// <summary>
        ///     将给定的字符串压缩为 GZip 字节数组。
        /// </summary>
        /// <param name="this">The stringToCompress to act on.</param>
        /// <param name="encoding">The encoding.</param>
        /// <returns>The string compressed into a GZip byte array.</returns>
        public static byte[] CompressGZip(this string @this, Encoding encoding)
        {
            var stringAsBytes = encoding.GetBytes(@this);
            using (var memoryStream = new MemoryStream())
            {
                using (var zipStream = new GZipStream(memoryStream, CompressionMode.Compress))
                {
                    zipStream.Write(stringAsBytes, 0, stringAsBytes.Length);
                    zipStream.Close();
                    return memoryStream.ToArray();
                }
            }
        }

        /// <summary>
        ///     将给定的字节数组压缩为 GZip 字节数组。
        /// </summary>
        /// <param name="this">The stringToCompress to act on.</param>
        /// <returns>The string compressed into a GZip byte array.</returns>
        public static byte[] CompressGZip(this byte[] @this)
        {
            using (var memoryStream = new MemoryStream())
            {
                using (var zipStream = new GZipStream(memoryStream, CompressionMode.Compress))
                {
                    zipStream.Write(@this, 0, @this.Length);
                    zipStream.Close();
                    return memoryStream.ToArray();
                }
            }
        }

        #endregion
    }
}