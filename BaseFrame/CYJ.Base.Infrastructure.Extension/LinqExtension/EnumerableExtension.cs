using System;
using System.Collections.Generic;
using System.Linq;

namespace CYJ.Utils.Extension.LinqExtension
{
    public static class EnumerableExtension
    {
        /// <summary>合并两个IEnumerable不同元素.</summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">The @this to act on.</param>
        /// <returns>
        ///     An enumerator that allows foreach to be used to process merge distinct inner
        ///     enumerable in this collection.
        /// </returns>
        public static IEnumerable<T> MergeDistinctInnerEnumerable<T>(this IEnumerable<IEnumerable<T>> @this)
        {
            var listItem = @this.ToList();

            var list = new List<T>();

            foreach (var item in listItem) list = list.Union(item).ToList();

            return list;
        }

        /// <summary>合并两个IEnumerable不同元素</summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">The @this to act on.</param>
        /// <returns>
        ///     An enumerator that allows foreach to be used to process merge inner enumerable in
        ///     this collection.
        /// </returns>
        public static IEnumerable<T> MergeInnerEnumerable<T>(this IEnumerable<IEnumerable<T>> @this)
        {
            var listItem = @this.ToList();

            var list = new List<T>();

            foreach (var item in listItem) list.AddRange(item);

            return list;
        }

        /// <summary>
        ///    判断当前IEnumerable是否包含指定的所有元素
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">The @this to act on.</param>
        /// <param name="values">A variable-length parameters list containing values.</param>
        /// <returns>true if it succeeds, false if it fails.</returns>
        public static bool IsContainsAll<T>(this IEnumerable<T> @this, params T[] values)
        {
            var list = @this.ToArray();
            foreach (var value in values)
                if (!list.Contains(value))
                    return false;

            return true;
        }

        /// <summary>
        ///    判断当前IEnumerable是否包含指定的数组任一元素
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">The @this to act on.</param>
        /// <param name="values">A variable-length parameters list containing values.</param>
        /// <returns>true if it succeeds, false if it fails.</returns>
        public static bool IsContainsAny<T>(this IEnumerable<T> @this, params T[] values)
        {
            var list = @this.ToArray();
            foreach (var value in values)
                if (list.Contains(value))
                    return true;

            return false;
        }

        /// <summary>
        ///     遍历操作当前IEnumerable每一项
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">The @this to act on.</param>
        /// <param name="action">The action.</param>
        /// <returns>An enumerator that allows foreach to be used to process for each in this collection.</returns>
        public static IEnumerable<T> ForEach<T>(this IEnumerable<T> @this, Action<T> action)
        {
            var array = @this.ToArray();
            foreach (var t in array) action(t);
            return array;
        }

        /// <summary>遍历操作当前IEnumerable每一项</summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">The @this to act on.</param>
        /// <param name="action">The action.</param>
        /// <returns>An enumerator that allows foreach to be used to process for each in this collection.</returns>
        public static IEnumerable<T> ForEach<T>(this IEnumerable<T> @this, Action<T, int> action)
        {
            var array = @this.ToArray();

            for (var i = 0; i < array.Length; i++) action(array[i], i);

            return array;
        }

        /// <summary>
        ///    判断IEnumerable 是否没有元素
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">The collection to act on.</param>
        /// <returns>true if empty, false if not.</returns>
        public static bool IsEmpty<T>(this IEnumerable<T> @this)
        {
            return !@this.Any();
        }

        /// <summary>
        ///    判断IEnumerable 是否有元素
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">The collection to act on.</param>
        /// <returns>true if a not is t>, false if not.</returns>
        public static bool IsNotEmpty<T>(this IEnumerable<T> @this)
        {
            return @this.Any();
        }

        /// <summary>
        ///   判断IEnumerable 是否有元素且不为Null
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">The collection to act on.</param>
        /// <returns>true if a not null or is t>, false if not.</returns>
        public static bool IsNotNullOrEmpty<T>(this IEnumerable<T> @this)
        {
            return @this != null && @this.Any();
        }

        /// <summary>
        ///    判断IEnumerable 是否没有元素或者为Null
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">The collection to act on.</param>
        /// <returns>true if a null or is t>, false if not.</returns>
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> @this)
        {
            return @this == null || !@this.Any();
        }

        /// <summary>
        ///    使用指定的分隔符连接 IEnumerable 的所有元素
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">An IEnumerable that contains the elements to concatenate.</param>
        /// <param name="separator">
        ///     The string to use as a separator. separator is included in the returned string only if
        ///     value has more than one element.
        /// </param>
        /// <returns>
        ///     A string that consists of the elements in value delimited by the separator string. If value is an empty array,
        ///     the method returns String.Empty.
        /// </returns>
        public static string StringJoin<T>(this IEnumerable<T> @this, string separator)
        {
            return string.Join(separator, @this);
        }

        /// <summary>
        ///     使用指定的分隔符连接 IEnumerable 的所有元素
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">The @this to act on.</param>
        /// <param name="separator">
        ///     The string to use as a separator. separator is included in the
        ///     returned string only if value has more than one element.
        /// </param>
        /// <returns>
        ///     A string that consists of the elements in value delimited by the separator string. If
        ///     value is an empty array, the method returns String.Empty.
        /// </returns>
        public static string StringJoin<T>(this IEnumerable<T> @this, char separator)
        {
            return string.Join(separator.ToString(), @this);
        }
    }
}