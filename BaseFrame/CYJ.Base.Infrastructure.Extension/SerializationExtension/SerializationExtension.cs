﻿using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

// ReSharper disable once CheckNamespace
namespace Aquarium.Util.Extension.SerializationExtension
{
    public static class SerializationExtension
    {



        #region SerializeBinary

        /// <summary>
        ///     An object extension method that serialize an object to binary.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">The @this to act on.</param>
        /// <returns>A string.</returns>
        public static string SerializeBinary<T>(this T @this)
        {
            var binaryWrite = new BinaryFormatter();

            using (var memoryStream = new MemoryStream())
            {
                binaryWrite.Serialize(memoryStream, @this);
                return Encoding.Default.GetString(memoryStream.ToArray());
            }
        }

        /// <summary>
        ///     An object extension method that serialize an object to binary.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">The @this to act on.</param>
        /// <param name="encoding">The encoding.</param>
        /// <returns>A string.</returns>
        public static string SerializeBinary<T>(this T @this, Encoding encoding)
        {
            var binaryWrite = new BinaryFormatter();

            using (var memoryStream = new MemoryStream())
            {
                binaryWrite.Serialize(memoryStream, @this);
                return encoding.GetString(memoryStream.ToArray());
            }
        }

        #endregion
    }
}