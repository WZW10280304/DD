using System;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Newtonsoft.Json;

namespace CYJ.Utils.Extension.ObjectExtension
{
    public static class ObjectExtension
    {
        #region 类型转换

        /// <summary>
        ///     转换源目标类型到目标对象类型
        /// </summary>
        /// <typeparam name="T">Generic type parameter. The specified type.</typeparam>
        /// <param name="this">The @this to act on.</param>
        /// <returns>The object as the specified type.</returns>
        public static T To<T>(this object @this)
        {
            return (T) @this;
        }

        /// <summary>
        ///     判断对象是否为null
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static bool IsNull(this object obj)
        {
            return obj == null;
        }

        /// <summary>
        ///     转换源目标类型到目标对象类型，无法转换的话转换成默认值
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">The @this to act on.</param>
        /// <returns>A T.</returns>
        public static T ToOrDefault<T>(this object @this)
        {
            try
            {
                return (T) @this;
            }
            catch (Exception)
            {
                return default(T);
            }
        }

        /// <summary>
        ///     A T extension method that makes a deep copy of '@this' object.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">The @this to act on.</param>
        /// <returns>the copied object.</returns>
        public static T DeepClone<T>(this T @this)
        {
            IFormatter formatter = new BinaryFormatter();
            using (var stream = new MemoryStream())
            {
                formatter.Serialize(stream, @this);
                stream.Seek(0, SeekOrigin.Begin);
                return (T) formatter.Deserialize(stream);
            }
        }
        /// <summary>
        /// 使用Json序列化的方式深拷贝
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="this"></param>
        /// <returns></returns>
        public static T DeepCloneModel<T>(this T @this)
        {
            var json = JsonConvert.SerializeObject(@this);
            try
            {
                return JsonConvert.DeserializeObject<T>(json);
            }
            catch (Exception e)
            {
                return default(T);
            }
        }

        /// <summary>
        ///     A T extension method that shallow copy.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">The @this to act on.</param>
        /// <returns>A T.</returns>
        public static T ShallowCopy<T>(this T @this)
        {
            var method = @this.GetType().GetMethod("MemberwiseClone", BindingFlags.NonPublic | BindingFlags.Instance);
            return (T) method.Invoke(@this, null);
        }

        /// <summary>
        ///     转换源目标类型到目标对象类型，无法转换的话转换成默认值
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">The @this to act on.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>A T.</returns>
        public static T ToOrDefault<T>(this object @this, T defaultValue)
        {
            try
            {
                return (T) @this;
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }

        /// <summary>
        ///     转换源目标类型到目标对象类型，无法转换的话转换成默认值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="this"></param>
        /// <param name="defaultValueFactory"></param>
        /// <returns></returns>
        public static T ToOrDefault<T>(this object @this, Func<T> defaultValueFactory)
        {
            try
            {
                return (T) @this;
            }
            catch (Exception)
            {
                return defaultValueFactory();
            }
        }

        /// <summary>
        ///     转换源目标类型到目标对象类型，无法转换的话转换成默认值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="this"></param>
        /// <param name="defaultValueFactory"></param>
        /// <returns></returns>
        public static T ToOrDefault<T>(this object @this, Func<object, T> defaultValueFactory)
        {
            try
            {
                return (T) @this;
            }
            catch (Exception)
            {
                return defaultValueFactory(@this);
            }
        }

        #endregion
    }
}