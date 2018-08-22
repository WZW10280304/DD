using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

// ReSharper disable once CheckNamespace
namespace Aquarium.Util.Extension.EnumExtension
{
    public static class EnumExtension
    {
        /// <summary>
        ///    获取枚举值注释值
        /// </summary>
        /// <param name="value">The value to act on.</param>
        /// <returns>The description attribute.</returns>
        public static string GetDescription(this Enum value)
        {
            if (value.GetType().GetField(value.ToString()).GetCustomAttributes(typeof(DescriptionAttribute), false)
                .FirstOrDefault() is DescriptionAttribute attr) return attr.Description;
            return string.Empty;
        }

        /// <summary>
        ///     枚举值是否在枚举中
        /// </summary>
        /// <param name="this">The object to be compared.</param>
        /// <param name="values">The value list to compare with the object.</param>
        /// <returns>true if the values list contains the object, else false.</returns>
        public static bool In(this Enum @this, params Enum[] values)
        {
            return Array.IndexOf(values, @this) != -1;
        }

        /// <summary>
        ///     值是否不在枚举中
        /// </summary>
        /// <param name="this">The object to be compared.</param>
        /// <param name="values">The value list to compare with the object.</param>
        /// <returns>true if the values list doesn't contains the object, else false.</returns>
        public static bool NotIn(this Enum @this, params Enum[] values)
        {
            return Array.IndexOf(values, @this) == -1;
        }

        /// <summary>
        ///    将字符串转换为枚举
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static T ToEnum<T>(this string obj)
        {
            //return (T)Enum.ToObject(typeof(T), obj);
            return (T) Enum.Parse(typeof(T), obj);
        }
        /// <summary>
        /// 把int转换成枚举值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static T ToEnum<T>(this int obj)
        {
            return (T) Enum.Parse(typeof(T), obj.ToString());
        }

        /// <summary>
        ///     获取枚举的名称
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string GetEnumName(this Enum obj)
        {
            return Enum.GetName(obj.GetType(), obj);
        }

        /// <summary>
        ///     获取枚举项的Attribute
        /// </summary>
        /// <typeparam name="T">自定义的Attribute</typeparam>
        /// <param name="source">枚举</param>
        /// <returns>返回枚举,否则返回null</returns>
        public static T GetCustomAttribute<T>(this Enum source) where T : Attribute
        {
            var sourceType = source.GetType();
            var sourceName = source.GetEnumName();
            var field = sourceType.GetField(sourceName);
            var attributes = field.GetCustomAttributes(typeof(T), false);
            return attributes.OfType<T>().FirstOrDefault();
        }


        /// <summary>
        ///     根据枚举获取枚举
        /// </summary>
        /// <param name="descript"></param>
        /// <returns></returns>
        public static Enum GetEnumByDescript<T>(this Enum descript)
        {
            var items = Enum.GetValues(typeof(T));
            return items.Cast<Enum>().FirstOrDefault(item => descript.ToString().Equals(item.GetDescription()));
        }

        /// <summary>
        ///      遍历枚举类型生成字典， key 为列Description,value 为 DefaultValue
        /// </summary>
        /// <param name="eType"></param>
        /// <returns></returns>
        public static IDictionary<string, string> GetEnumDefaultValueAndDescription(Type eType)
        {
            var returnDic = new Dictionary<string, string>();

            var enumType = eType;
            var values = Enum.GetValues(enumType).Cast<int?>();

            foreach (var item in values)
            {
                var descKey = item.GetDescription(enumType);
                if (!string.IsNullOrEmpty(descKey)) returnDic[descKey] = item.GetEnumDefaultValue(enumType);
            }

            return returnDic;
        }


        /// <summary>
        ///     返回枚举项的描述信息。
        /// </summary>
        /// <param name="state">要获取描述信息的枚举项。</param>
        /// <param name="eType">枚举类型</param>
        /// <returns>枚举项的描述信息。</returns>
        public static string GetDescription(this int? state, Type eType)
        {
            if (!state.HasValue)
                return string.Empty;

            var enumType = eType;
            var name = Enum.GetName(enumType, state.Value);
            if (name == null) return null;
            // 获取枚举字段
            var fieldInfo = enumType.GetField(name);
            if (fieldInfo == null) return null;
            return Attribute.GetCustomAttribute(fieldInfo,
                typeof(DescriptionAttribute), false) is DescriptionAttribute attr
                ? attr.Description
                : null;
        }

        /// <summary>
        ///     返回枚举默认值
        /// </summary>
        /// <param name="state"></param>
        /// <param name="eType"></param>
        /// <returns></returns>
        public static string GetEnumDefaultValue(this int? state, Type eType)
        {
            if (!state.HasValue)
                return string.Empty;

            var enumType = eType;
            var name = Enum.GetName(enumType, state.Value);
            if (name == null) return null;
            // 获取枚举字段。
            var fieldInfo = enumType.GetField(name);
            if (fieldInfo == null) return null;
            return Attribute.GetCustomAttribute(fieldInfo,
                typeof(DefaultValueAttribute), false) is DefaultValueAttribute attr
                ? attr.Value.ToString()
                : null;
        }
    }
}