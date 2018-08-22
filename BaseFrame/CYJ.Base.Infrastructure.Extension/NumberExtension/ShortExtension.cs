using System;

// ReSharper disable once CheckNamespace
namespace Aquarium.Util.Extension.NumberExtension
{
    public static class ShortExtension
    {
        /// <summary>
        ///     Returns the specified   signed integer value as an array of bytes.
        /// </summary>
        /// <param name="value">The number to convert.</param>
        /// <returns>An array of bytes with length 2.</returns>
        public static byte[] GetBytes(this short value)
        {
            return BitConverter.GetBytes(value);
        }

        /// <summary>
        ///     Returns the absolute value of a   signed integer.
        /// </summary>
        /// <param name="value">A number that is greater than , but less than or equal to .</param>
        /// <returns>A   signed integer, x, such that 0 ? x ?.</returns>
        public static short Abs(this short value)
        {
            return Math.Abs(value);
        }

        /// <summary>
        ///     Returns the larger of two   signed integers.
        /// </summary>
        /// <param name="val1">The first of two   signed integers to compare.</param>
        /// <param name="val2">The second of two   signed integers to compare.</param>
        /// <returns>Parameter  or , whichever is larger.</returns>
        public static short Max(this short val1, short val2)
        {
            return Math.Max(val1, val2);
        }

        /// <summary>
        ///     Returns the smaller of two   signed integers.
        /// </summary>
        /// <param name="val1">The first of two   signed integers to compare.</param>
        /// <param name="val2">The second of two   signed integers to compare.</param>
        /// <returns>Parameter  or , whichever is smaller.</returns>
        public static short Min(this short val1, short val2)
        {
            return Math.Min(val1, val2);
        }

        /// <summary>
        ///     Returns a value indicating the sign of a   signed integer.
        /// </summary>
        /// <param name="value">A signed number.</param>
        /// <returns>
        ///     A number that indicates the sign of , as shown in the following table.Return value Meaning -1  is less than
        ///     zero. 0  is equal to zero. 1  is greater than zero.
        /// </returns>
        public static int Sign(this short value)
        {
            return Math.Sign(value);
        }
    }
}