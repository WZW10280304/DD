using System;
using System.Collections;

// ReSharper disable once CheckNamespace
namespace Aquarium.Util.Extension.ArrayExtension
{
    public static class ArrayExtension
    {
        /// <summary>
        ///     搜索指定的对象, 并返回第一个匹配项的索引。
        /// </summary>
        /// <param name="array">The one-dimensional  to search.</param>
        /// <param name="value">The object to locate in .</param>
        /// <returns>
        ///     The index of the first occurrence of  within the entire , if found; otherwise, the lower bound of the array
        ///     minus 1.
        /// </returns>
        public static int IndexOf(this Array array, object value)
        {
            return Array.IndexOf(array, value);
        }

        /// <summary>
        ///     搜索指定的对象, 并返回整个项中最后一个匹配项。
        /// </summary>
        /// <param name="array">The one-dimensional  to search.</param>
        /// <param name="value">The object to locate in .</param>
        /// <returns>
        ///     The index of the last occurrence of  within the entire , if found; otherwise, the lower bound of the array
        ///     minus 1.
        /// </returns>
        public static int LastIndexOf(this Array array, object value)
        {
            return Array.LastIndexOf(array, value);
        }

        /// <summary>
        ///     搜索指定的对象, 并返回整个项中最后一个匹配项。
        /// </summary>
        /// <param name="array">The one-dimensional  to search.</param>
        /// <param name="value">The object to locate in .</param>
        /// <param name="startIndex">The starting index of the backward search.</param>
        /// <returns>
        ///     The index of the last occurrence of  within the range of elements in  that extends from the first element to ,
        ///     if found; otherwise, the lower bound of the array minus 1.
        /// </returns>
        public static int LastIndexOf(this Array array, object value, int startIndex)
        {
            return Array.LastIndexOf(array, value, startIndex);
        }

        /// <summary>
        ///     元素进行排序。
        /// </summary>
        /// <param name="array">The one-dimensional  to sort.</param>
        public static void Sort(this Array array)
        {
            Array.Sort(array);
        }

        /// <summary>
        ///     元素进行排序 (一个包含键, 另一个包含相应的项) 的基础上, 首先使用每个键的实现。
        /// </summary>
        /// <param name="array">The one-dimensional  to sort.</param>
        /// <param name="items">
        ///     The one-dimensional  that contains the items that correspond to each of the keys in the .-or-
        ///     null to sort only the .
        /// </param>
        /// ###
        /// <param name="keys">The one-dimensional  that contains the keys to sort.</param>
        public static void Sort(this Array array, Array items)
        {
            Array.Sort(array, items);
        }

        /// <summary>
        ///     元素进行排序
        /// </summary>
        /// <param name="array">The one-dimensional  to sort.</param>
        /// <param name="index">The starting index of the range to sort.</param>
        /// <param name="length">The number of elements in the range to sort.</param>
        public static void Sort(this Array array, int index, int length)
        {
            Array.Sort(array, index, length);
        }

        /// <summary>
        ///     元素进行排序
        /// </summary>
        /// <param name="array">The one-dimensional  to sort.</param>
        /// <param name="items">
        ///     The one-dimensional  that contains the items that correspond to each of the keys in the .-or-
        ///     null to sort only the .
        /// </param>
        /// <param name="index">The starting index of the range to sort.</param>
        /// <param name="length">The number of elements in the range to sort.</param>
        /// ###
        public static void Sort(this Array array, Array items, int index, int length)
        {
            Array.Sort(array, items, index, length);
        }

        /// <summary>
        ///     元素进行排序
        /// </summary>
        /// <param name="array">The one-dimensional  to sort.</param>
        /// <param name="comparer">
        ///     The  implementation to use when comparing elements.-or-null to use the  implementation of
        ///     each element.
        /// </param>
        public static void Sort(this Array array, IComparer comparer)
        {
            Array.Sort(array, comparer);
        }

        /// <summary>
        ///     元素进行排序
        /// </summary>
        /// <param name="array">The one-dimensional  to sort.</param>
        /// <param name="items">
        ///     The one-dimensional  that contains the items that correspond to each of the keys in the .-or-
        ///     null to sort only the .
        /// </param>
        /// <param name="comparer">
        ///     The  implementation to use when comparing elements.-or-null to use the  implementation of
        ///     each element.
        /// </param>
        /// ###
        public static void Sort(this Array array, Array items, IComparer comparer)
        {
            Array.Sort(array, items, comparer);
        }

        /// <summary>
        ///     元素进行排序
        /// </summary>
        /// <param name="array">The one-dimensional  to sort.</param>
        /// <param name="index">The starting index of the range to sort.</param>
        /// <param name="length">The number of elements in the range to sort.</param>
        /// <param name="comparer">
        ///     The  implementation to use when comparing elements.-or-null to use the  implementation of
        ///     each element.
        /// </param>
        public static void Sort(this Array array, int index, int length, IComparer comparer)
        {
            Array.Sort(array, index, length, comparer);
        }

        /// <summary>
        ///     它检查数组是否低于指定的索引。
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="index">Zero-based index of the.</param>
        /// <returns>true if it succeeds, false if it fails.</returns>
        public static bool WithinIndex(this Array @this, int index)
        {
            return index >= 0 && index < @this.Length;
        }

        /// <summary>
        ///     它检查数组是否低于指定的索引。
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="index">Zero-based index of the.</param>
        /// <param name="dimension">(Optional) the dimension.</param>
        /// <returns>true if it succeeds, false if it fails.</returns>
        public static bool WithinIndex(this Array @this, int index, int dimension = 0)
        {
            return index >= @this.GetLowerBound(dimension) && index <= @this.GetUpperBound(dimension);
        }

        /// <summary>
        ///     清除数组的元素
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        public static void ClearAll(this Array @this)
        {
            Array.Clear(@this, 0, @this.Length);
        }

        /// <summary>
        ///     将指定值分配给指定数组中特定位置的字节。
        /// </summary>
        /// <param name="array">An array.</param>
        /// <param name="index">A location in the array.</param>
        /// <param name="value">A value to assign.</param>
        public static void SetByte(this Array array, int index, byte value)
        {
            Buffer.SetByte(array, index, value);
        }

        /// <summary>
        ///     返回指定数组中的字节数
        /// </summary>
        /// <param name="array">An array.</param>
        /// <returns>The number of bytes in the array.</returns>
        public static int ByteLength(this Array array)
        {
            return Buffer.ByteLength(array);
        }

        /// <summary>
        ///     检索指定数组中指定位置处的字节。
        /// </summary>
        /// <param name="array">An array.</param>
        /// <param name="index">A location in the array.</param>
        /// <returns>Returns the  byte in the array.</returns>
        public static byte GetByte(this Array array, int index)
        {
            return Buffer.GetByte(array, index);
        }

        /// <summary>
        ///     从特定偏移量开始到目标数组的源数组中复制指定的字节数从目标数组指定的偏移量开始。
        /// </summary>
        /// <param name="src">The source buffer.</param>
        /// <param name="srcOffset">The zero-based byte offset into .</param>
        /// <param name="dst">The destination buffer.</param>
        /// <param name="dstOffset">The zero-based byte offset into .</param>
        /// <param name="count">The number of bytes to copy.</param>
        public static void BlockCopy(this Array src, int srcOffset, Array dst, int dstOffset, int count)
        {
            Buffer.BlockCopy(src, srcOffset, dst, dstOffset, count);
        }

        /// <summary>
        ///     元素排序
        /// </summary>
        /// <param name="array">The one-dimensional  to sort.</param>
        /// <param name="items">
        ///     The one-dimensional  that contains the items that correspond to each of the keys in the .-or-
        ///     null to sort only the .
        /// </param>
        /// <param name="index">The starting index of the range to sort.</param>
        /// <param name="length">The number of elements in the range to sort.</param>
        /// <param name="comparer">
        ///     The  implementation to use when comparing elements.-or-null to use the  implementation of
        ///     each element.
        /// </param>
        /// ###
        /// <param name="keys">The one-dimensional  that contains the keys to sort.</param>
        public static void Sort(this Array array, Array items, int index, int length, IComparer comparer)
        {
            Array.Sort(array, items, index, length, comparer);
        }

        /// <summary>
        ///     反转元素顺序
        /// </summary>
        /// <param name="array">The one-dimensional  to reverse.</param>
        public static void Reverse(this Array array)
        {
            Array.Reverse(array);
        }

        /// <summary>
        ///     反转元素顺序
        /// </summary>
        /// <param name="array">The one-dimensional  to reverse.</param>
        /// <param name="index">The starting index of the section to reverse.</param>
        /// <param name="length">The number of elements in the section to reverse.</param>
        public static void Reverse(this Array array, int index, int length)
        {
            Array.Reverse(array, index, length);
        }

        /// <summary>
        ///     搜索指定的对象, 并返回整个项中最后一个匹配项
        /// </summary>
        /// <param name="array">The one-dimensional  to search.</param>
        /// <param name="value">The object to locate in .</param>
        /// <param name="startIndex">The starting index of the backward search.</param>
        /// <param name="count">The number of elements in the section to search.</param>
        /// <returns>
        ///     The index of the last occurrence of  within the range of elements in  that contains the number of elements
        ///     specified in  and ends at , if found; otherwise, the lower bound of the array minus 1.
        /// </returns>
        public static int LastIndexOf(this Array array, object value, int startIndex, int count)
        {
            return Array.LastIndexOf(array, value, startIndex, count);
        }

        /// <summary>
        ///     搜索指定的对象, 并返回第一个匹配项的索引。
        /// </summary>
        /// <param name="array">The one-dimensional  to search.</param>
        /// <param name="value">The object to locate in .</param>
        /// <param name="startIndex">The starting index of the search. 0 (zero) is valid in an empty array.</param>
        /// <returns>
        ///     The index of the first occurrence of  within the range of elements in  that extends from  to the last element,
        ///     if found; otherwise, the lower bound of the array minus 1.
        /// </returns>
        public static int IndexOf(this Array array, object value, int startIndex)
        {
            return Array.IndexOf(array, value, startIndex);
        }

        /// <summary>
        ///     搜索指定的对象, 并返回第一个匹配项的索引。
        /// </summary>
        /// <param name="array">The one-dimensional  to search.</param>
        /// <param name="value">The object to locate in .</param>
        /// <param name="startIndex">The starting index of the search. 0 (zero) is valid in an empty array.</param>
        /// <param name="count">The number of elements in the section to search.</param>
        /// <returns>
        ///     The index of the first occurrence of  within the range of elements in  that starts at  and contains the
        ///     number of elements specified in , if found; otherwise, the lower bound of the array minus 1.
        /// </returns>
        public static int IndexOf(this Array array, object value, int startIndex, int count)
        {
            return Array.IndexOf(array, value, startIndex, count);
        }

        /// <summary>
        ///     从源数组复制指定长度元素到目标数组
        /// </summary>
        /// <param name="sourceArray">The  that contains the data to copy.</param>
        /// <param name="destinationArray">The  that receives the data.</param>
        /// <param name="length">A 32-bit integer that represents the number of elements to copy.</param>
        public static void Copy(this Array sourceArray, Array destinationArray, int length)
        {
            Array.Copy(sourceArray, destinationArray, length);
        }

        /// <summary>
        ///     从源数组复制指定长度元素到目标数组
        /// </summary>
        /// <param name="sourceArray">The  that contains the data to copy.</param>
        /// <param name="sourceIndex">A 32-bit integer that represents the index in the  at which copying begins.</param>
        /// <param name="destinationArray">The  that receives the data.</param>
        /// <param name="destinationIndex">A 32-bit integer that represents the index in the  at which storing begins.</param>
        /// <param name="length">A 32-bit integer that represents the number of elements to copy.</param>
        public static void Copy(this Array sourceArray, int sourceIndex, Array destinationArray, int destinationIndex,
            int length)
        {
            Array.Copy(sourceArray, sourceIndex, destinationArray, destinationIndex, length);
        }

        /// <summary>
        ///     从源数组复制指定长度元素到目标数组
        /// </summary>
        /// <param name="sourceArray">The  that contains the data to copy.</param>
        /// <param name="destinationArray">The  that receives the data.</param>
        /// <param name="length">
        ///     A 64-bit integer that represents the number of elements to copy. The integer must be between
        ///     zero and , inclusive.
        /// </param>
        public static void Copy(this Array sourceArray, Array destinationArray, long length)
        {
            Array.Copy(sourceArray, destinationArray, length);
        }

        /// <summary>
        ///     从源数组复制指定长度元素到目标数组
        /// </summary>
        /// <param name="sourceArray">The  that contains the data to copy.</param>
        /// <param name="sourceIndex">A 64-bit integer that represents the index in the  at which copying begins.</param>
        /// <param name="destinationArray">The  that receives the data.</param>
        /// <param name="destinationIndex">A 64-bit integer that represents the index in the  at which storing begins.</param>
        /// <param name="length">
        ///     A 64-bit integer that represents the number of elements to copy. The integer must be between
        ///     zero and , inclusive.
        /// </param>
        public static void Copy(this Array sourceArray, long sourceIndex, Array destinationArray, long destinationIndex,
            long length)
        {
            Array.Copy(sourceArray, sourceIndex, destinationArray, destinationIndex, length);
        }

        /// <summary>
        ///     从指定的数组指定索引复制指定长度的元素, 并将它们插入到另一个数组的指定位置
        /// </summary>
        /// <param name="sourceArray">The  that contains the data to copy.</param>
        /// <param name="sourceIndex">A 32-bit integer that represents the index in the  at which copying begins.</param>
        /// <param name="destinationArray">The  that receives the data.</param>
        /// <param name="destinationIndex">A 32-bit integer that represents the index in the  at which storing begins.</param>
        /// <param name="length">A 32-bit integer that represents the number of elements to copy.</param>
        public static void ConstrainedCopy(this Array sourceArray, int sourceIndex, Array destinationArray,
            int destinationIndex, int length)
        {
            Array.ConstrainedCopy(sourceArray, sourceIndex, destinationArray, destinationIndex, length);
        }

        /// <summary>
        ///     移除目标数组指定位置指定长度的元素
        /// </summary>
        /// <param name="array">The  whose elements need to be cleared.</param>
        /// <param name="index">The starting index of the range of elements to clear.</param>
        /// <param name="length">The number of elements to clear.</param>
        public static void Clear(this Array array, int index, int length)
        {
            Array.Clear(array, index, length);
        }

        /// <summary>
        ///     在数组中搜索特定元素
        /// </summary>
        /// <param name="array">The sorted one-dimensional  to search.</param>
        /// <param name="value">The object to search for.</param>
        /// <returns>
        ///     The index of the specified  in the specified , if  is found. If  is not found and  is less than one or more
        ///     elements in , a negative number which is the bitwise complement of the index of the first element that is
        ///     larger than . If  is not found and  is greater than any of the elements in , a negative number which is the
        ///     bitwise complement of (the index of the last element plus 1).
        /// </returns>
        public static int BinarySearch(this Array array, object value)
        {
            return Array.BinarySearch(array, value);
        }

        /// <summary>
        ///     在数组中搜索特定元素
        /// </summary>
        /// <param name="array">The sorted one-dimensional  to search.</param>
        /// <param name="index">The starting index of the range to search.</param>
        /// <param name="length">The length of the range to search.</param>
        /// <param name="value">The object to search for.</param>
        /// <returns>
        ///     The index of the specified  in the specified , if  is found. If  is not found and  is less than one or more
        ///     elements in , a negative number which is the bitwise complement of the index of the first element that is
        ///     larger than . If  is not found and  is greater than any of the elements in , a negative number which is the
        ///     bitwise complement of (the index of the last element plus 1).
        /// </returns>
        public static int BinarySearch(this Array array, int index, int length, object value)
        {
            return Array.BinarySearch(array, index, length, value);
        }

        /// <summary>
        ///     在数组中搜索特定元素
        /// </summary>
        /// <param name="array">The sorted one-dimensional  to search.</param>
        /// <param name="value">The object to search for.</param>
        /// <param name="comparer">
        ///     The  implementation to use when comparing elements.-or- null to use the  implementation
        ///     of each element.
        /// </param>
        /// <returns>
        ///     The index of the specified  in the specified , if  is found. If  is not found and  is less than one or more
        ///     elements in , a negative number which is the bitwise complement of the index of the first element that is
        ///     larger than . If  is not found and  is greater than any of the elements in , a negative number which is the
        ///     bitwise complement of (the index of the last element plus 1).
        /// </returns>
        public static int BinarySearch(this Array array, object value, IComparer comparer)
        {
            return Array.BinarySearch(array, value, comparer);
        }

        /// <summary>
        ///     在数组中搜索特定元素
        /// </summary>
        /// <param name="array">The sorted one-dimensional  to search.</param>
        /// <param name="index">The starting index of the range to search.</param>
        /// <param name="length">The length of the range to search.</param>
        /// <param name="value">The object to search for.</param>
        /// <param name="comparer">
        ///     The  implementation to use when comparing elements.-or- null to use the  implementation
        ///     of each element.
        /// </param>
        /// <returns>
        ///     The index of the specified  in the specified , if  is found. If  is not found and  is less than one or more
        ///     elements in , a negative number which is the bitwise complement of the index of the first element that is
        ///     larger than . If  is not found and  is greater than any of the elements in , a negative number which is the
        ///     bitwise complement of (the index of the last element plus 1).
        /// </returns>
        public static int BinarySearch(this Array array, int index, int length, object value, IComparer comparer)
        {
            return Array.BinarySearch(array, index, length, value, comparer);
        }

    
    }
}