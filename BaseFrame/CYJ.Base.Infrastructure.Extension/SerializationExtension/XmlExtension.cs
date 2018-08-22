// ReSharper disable once CheckNamespace

using System;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using Aquarium.Util.Extension.IOExtension;
using Aquarium.Util.Extension.ObjectExtension;
using Aquarium.Util.Extension.StringExtension;

// ReSharper disable once CheckNamespace
namespace Aquarium.Util.Extension.SerializationExtension
{
    public static class XmlExtension
    {
        /// <summary>
        ///     将对象转换为Json字符串
        /// </summary>
        /// <param name="xmlData"></param>
        /// <returns></returns>
        public static string ToXml(this object xmlData)
        {
            using (var stream = new MemoryStream())
            {
                var xml = new XmlSerializer(xmlData.GetType());
                xml.Serialize(stream, xmlData);
                stream.Position = 0;
                using (var sr = new StreamReader(stream))
                {
                    var str = sr.ReadToEnd();
                    return str;
                }
            }
        }


        /// <summary>
        ///     将xml字符串转换为对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="xmlStr"></param>
        /// <returns></returns>
        public static T ToObjectFromXml<T>(this string xmlStr)
        {
            try
            {
                using (var sr = xmlStr.ToStream(Encoding.UTF8))
                {
                    var xmldes = new XmlSerializer(typeof(T));
                    return ChangeTypeExtension.To<T>(xmldes.Deserialize(sr));
                }
            }
            catch (Exception)
            {
                return default(T);
            }
        }

        /// <summary>
        ///     将xml字符串转换为对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="file"></param>
        /// <returns></returns>
        public static T ToObjectFromXml<T>(this FileInfo file)
        {
            if (!file.Exists) throw new IOException($"Xml文件不存在,路径为{file.FullName}");
            var xmlStr = file.ReadAllText();
            return xmlStr.ToObjectFromXml<T>();
        }
    }
}