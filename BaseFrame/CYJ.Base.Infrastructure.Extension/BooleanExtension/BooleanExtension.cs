using System;

// ReSharper disable once CheckNamespace
namespace Aquarium.Util.Extension.BooleanExtension
{
    public static class BooleaneExtension
    {
        /// <summary>
        ///    转换为二进制表示形式
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>A binary represenation of this object.</returns>
        public static byte ToBinary(this bool @this)
        {
            return Convert.ToByte(@this);
        }

        /// <summary>
        ///    转换为int表示形式
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>A binary represenation of this object.</returns>
        public static int ToInt(this bool @this)
        {
            return @this ? 1 : 0;
        }


        /// <summary>
        ///    转换为字符串表示形式（可指定trueValue,falseValue,默认为true，false）
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="trueValue">The true value to be returned if the @this value is true.</param>
        /// <param name="falseValue">The false value to be returned if the @this value is false.</param>
        /// <returns>A string that represents of the current boolean value.</returns>
        public static string ToString(this bool @this, string trueValue="true", string falseValue= "false")
        {
            return @this ? trueValue : falseValue;
        }
    }
}