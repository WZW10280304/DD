using System;

// ReSharper disable once CheckNamespace
namespace Aquarium.Util.Extension.NumberExtension
{
    public static class DoubleExtension
    {
        #region 转换

        /// <summary>
        /// 转换为字节大小
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        public static string ToFileSize(this double size)
        {
            var units = new[] {"B", "KB", "MB", "GB", "TB", "PB"};
            const double mod = 1024.0;
            var i = 0;
            while (size >= mod)
            {
                size /= mod;
                i++;
            }

            return Math.Round(size) + units[i];
        }

        #endregion

        #region 判断

        /// <summary>
        ///    判断数字是否计算为正无穷大。
        /// </summary>
        /// <param name="d">A double-precision floating-point number.</param>
        /// <returns>true if  evaluates to  or ; otherwise, false.</returns>
        public static bool IsInfinity(this double d)
        {
            return double.IsInfinity(d);
        }

        /// <summary>
        ///    判断值是否是数字
        /// </summary>
        /// <param name="d">A double-precision floating-point number.</param>
        /// <returns>true if  evaluates to ; otherwise, false.</returns>
        public static bool IsNaN(this double d)
        {
            return double.IsNaN(d);
        }

        /// <summary>
        ///   判断数字是否计算为负无穷大。
        /// </summary>
        /// <param name="d">A double-precision floating-point number.</param>
        /// <returns>true if  evaluates to ; otherwise, false.</returns>
        public static bool IsNegativeInfinity(this double d)
        {
            return double.IsNegativeInfinity(d);
        }

        /// <summary>
        ///     判断数字是否计算为正无穷大。
        /// </summary>
        /// <param name="d">A double-precision floating-point number.</param>
        /// <returns>true if  evaluates to ; otherwise, false.</returns>
        public static bool IsPositiveInfinity(this double d)
        {
            return double.IsPositiveInfinity(d);
        }

        #endregion

        #region 计算

        /// <summary>
        ///     四舍五入保留小数点
        /// </summary>
        /// <param name="a">A double-precision floating-point number to be rounded.</param>
        /// <returns>
        ///     The integer nearest . If the fractional component of  is halfway between two integers, one of which is even
        ///     and the other odd, then the even number is returned. Note that this method returns a  instead of an integral
        ///     type.
        /// </returns>
        public static double Round(this double a)
        {
            return Math.Round(a, MidpointRounding.AwayFromZero);
        }

        /// <summary>
        ///     四舍五入保留小数点
        /// </summary>
        /// <param name="a">A double-precision floating-point number to be rounded.</param>
        /// <param name="digits">The number of fractional digits in the return value.</param>
        /// <returns>The number nearest to  that contains a number of fractional digits equal to .</returns>
        /// ###
        public static double Round(this double a, int digits)
        {
            return Math.Round(a, digits, MidpointRounding.AwayFromZero);
        }

        /// <summary>
        ///     四舍五入保留小数点
        /// </summary>
        /// <param name="a">A double-precision floating-point number to be rounded.</param>
        /// <param name="mode">Specification for how to round  if it is midway between two other numbers.</param>
        /// <returns>
        ///     The integer nearest . If  is halfway between two integers, one of which is even and the other odd, then
        ///     determines which of the two is returned.
        /// </returns>
        /// ###
        public static double Round(this double a, MidpointRounding mode)
        {
            return Math.Round(a, mode);
        }

        /// <summary>
        ///     四舍五入保留小数点
        /// </summary>
        /// <param name="a">A double-precision floating-point number to be rounded.</param>
        /// <param name="digits">The number of fractional digits in the return value.</param>
        /// <param name="mode">Specification for how to round  if it is midway between two other numbers.</param>
        /// <returns>
        ///     The number nearest to  that has a number of fractional digits equal to . If  has fewer fractional digits than
        ///     ,  is returned unchanged.
        /// </returns>
        /// ###
        public static double Round(this double a, int digits, MidpointRounding mode)
        {
            return Math.Round(a, digits, mode);
        }

        /// <summary>
        ///     幂计算
        /// </summary>
        /// <param name="x">A double-precision floating-point number to be raised to a power.</param>
        /// <param name="y">A double-precision floating-point number that specifies a power.</param>
        /// <returns>The number  raised to the power .</returns>
        public static double Pow(this double x, double y)
        {
            return Math.Pow(x, y);
        }

        /// <summary>
        ///     取最小值
        /// </summary>
        /// <param name="val1">The first of two double-precision floating-point numbers to compare.</param>
        /// <param name="val2">The second of two double-precision floating-point numbers to compare.</param>
        /// <returns>Parameter  or , whichever is smaller. If , , or both  and  are equal to ,  is returned.</returns>
        public static double Min(this double val1, double val2)
        {
            return Math.Min(val1, val2);
        }

        /// <summary>
        ///    获取数字的正负，返回-1小于0，返回1 大于0
        /// </summary>
        /// <param name="value">A signed number.</param>
        /// <returns>
        ///     A number that indicates the sign of , as shown in the following table.Return value Meaning -1  is less than
        ///     zero. 0  is equal to zero. 1  is greater than zero.
        /// </returns>
        public static int Sign(this double value)
        {
            return Math.Sign(value);
        }

        /// <summary>
        ///  计算指定角度的双曲正弦值。
        /// </summary>
        /// <param name="value">An angle, measured in radians.</param>
        /// <returns>The hyperbolic sine of . If  is equal to , , or , this method returns a  equal to .</returns>
        public static double Sinh(this double value)
        {
            return Math.Sinh(value);
        }

        /// <summary>
        ///    计算指定数字的平方根。
        /// </summary>
        /// <param name="d">The number whose square root is to be found.</param>
        /// <returns>
        ///     One of the values in the following table.  parameter Return value Zero or positive The positive square root
        ///     of . Negative Equals Equals.
        /// </returns>
        public static double Sqrt(this double d)
        {
            return Math.Sqrt(d);
        }

        /// <summary>
        ///     取整
        /// </summary>
        /// <param name="d">A number to truncate.</param>
        /// <returns>
        ///     The integral part of ; that is, the number that remains after any fractional digits have been discarded, or
        ///     one of the values listed in the following table. Return value.
        /// </returns>
        public static double Truncate(this double d)
        {
            return Math.Truncate(d);
        }


        /// <summary>
        ///    计算指定角度的双曲正切值。
        /// </summary>
        /// <param name="value">An angle, measured in radians.</param>
        /// <returns>
        ///     The hyperbolic tangent of . If  is equal to , this method returns -1. If value is equal to , this method
        ///     returns 1. If  is equal to , this method returns .
        /// </returns>
        public static double Tanh(this double value)
        {
            return Math.Tanh(value);
        }

        /// <summary>
        ///   计算指定角度的正切值
        /// </summary>
        /// <param name="a">An angle, measured in radians.</param>
        /// <returns>The tangent of . If  is equal to , , or , this method returns .</returns>
        public static double Tan(this double a)
        {
            return Math.Tan(a);
        }

        /// <summary>
        ///    计算指定角度的正弦值。
        /// </summary>
        /// <param name="a">An angle, measured in radians.</param>
        /// <returns>The sine of . If  is equal to , , or , this method returns .</returns>
        public static double Sin(this double a)
        {
            return Math.Sin(a);
        }

        /// <summary>
        ///    取最大值
        /// </summary>
        /// <param name="val1">The first of two double-precision floating-point numbers to compare.</param>
        /// <param name="val2">The second of two double-precision floating-point numbers to compare.</param>
        /// <returns>Parameter  or , whichever is larger. If , , or both  and  are equal to ,  is returned.</returns>
        public static double Max(this double val1, double val2)
        {
            return Math.Max(val1, val2);
        }

        /// <summary>
        ///     计算指定数字基于10的对数
        /// </summary>
        /// <param name="d">A number whose logarithm is to be found.</param>
        /// <returns>
        ///     One of the values in the following table.  parameter Return value Positive The base 10 log of ; that is, log
        ///     10. Zero Negative Equal to Equal to.
        /// </returns>
        public static double Log10(this double d)
        {
            return Math.Log10(d);
        }

        /// <summary>
        ///     计算指定基数中指定数字的对数
        /// </summary>
        /// <param name="d">The number whose logarithm is to be found.</param>
        /// <returns>
        ///     One of the values in the following table.  parameterReturn value Positive The natural logarithm of ; that is,
        ///     ln , or log eZero Negative Equal to Equal to.
        /// </returns>
        public static double Log(this double d)
        {
            return Math.Log(d);
        }

        /// <summary>
        ///    计算指定基数中指定数字的对数。
        /// </summary>
        /// <param name="d">The number whose logarithm is to be found.</param>
        /// <param name="newBase">The base of the logarithm.</param>
        /// <returns>
        ///     One of the values in the following table. (+Infinity denotes , -Infinity denotes , and NaN denotes .)Return
        ///     value&gt; 0(0 &lt;&lt; 1) -or-(&gt; 1)lognewBase(a)&lt; 0(any value)NaN(any value)&lt; 0NaN != 1 = 0NaN != 1
        ///     = +InfinityNaN = NaN(any value)NaN(any value) = NaNNaN(any value) = 1NaN = 00 &lt;&lt; 1 +Infinity = 0&gt; 1-
        ///     Infinity =  +Infinity0 &lt;&lt; 1-Infinity =  +Infinity&gt; 1+Infinity = 1 = 00 = 1 = +Infinity0.
        /// </returns>
        /// ###
        /// <param name="a">The number whose logarithm is to be found.</param>
        public static double Log(this double d, double newBase)
        {
            return Math.Log(d, newBase);
        }

        /// <summary>
        ///     计算由指定数字的除法由另一个指定编号所产生的余数。
        /// </summary>
        /// <param name="x">A dividend.</param>
        /// <param name="y">A divisor.</param>
        /// <returns>
        ///     A number equal to  - ( Q), where Q is the quotient of  /  rounded to the nearest integer (if  /  falls
        ///     halfway between two integers, the even integer is returned).If  - ( Q) is zero, the value +0 is returned if
        ///     is positive, or -0 if  is negative.If  = 0,  is returned.
        /// </returns>
        public static double IEEERemainder(this double x, double y)
        {
            return Math.IEEERemainder(x, y);
        }

        /// <summary>
        ///    向下取整
        /// </summary>
        /// <param name="d">A double-precision floating-point number.</param>
        /// <returns>The largest integer less than or equal to . If  is equal to , , or , that value is returned.</returns>
        public static double Floor(this double d)
        {
            return Math.Floor(d);
        }

   
        /// <summary>
        ///     计算指定角度的双曲余弦值。
        /// </summary>
        /// <param name="value">An angle, measured in radians.</param>
        /// <returns>The hyperbolic cosine of . If  is equal to  or ,  is returned. If  is equal to ,  is returned.</returns>
        public static double Cosh(this double value)
        {
            return Math.Cosh(value);
        }

        /// <summary>
        ///    计算指定角度的余弦值。
        /// </summary>
        /// <param name="d">An angle, measured in radians.</param>
        /// <returns>The cosine of . If  is equal to , , or , this method returns .</returns>
        public static double Cos(this double d)
        {
            return Math.Cos(d);
        }

        /// <summary>
        ///    向上取整
        /// </summary>
        /// <param name="a">A double-precision floating-point number.</param>
        /// <returns>
        ///     The smallest integral value that is greater than or equal to . If  is equal to , , or , that value is
        ///     returned. Note that this method returns a  instead of an integral type.
        /// </returns>
        public static double Ceiling(this double a)
        {
            return Math.Ceiling(a);
        }

        /// <summary>
        ///    计算切线为两个指定数字的商的角度。
        /// </summary>
        /// <param name="y">The y coordinate of a point.</param>
        /// <param name="x">The x coordinate of a point.</param>
        /// <returns>
        ///     An angle, ?, measured in radians, such that -?????, and tan(?) =  / , where (, ) is a point in the Cartesian
        ///     plane. Observe the following: For (, ) in quadrant 1, 0 &lt; ? &lt; ?/2.For (, ) in quadrant 2, ?/2 &lt;
        ///     ???.For (, ) in quadrant 3, -? &lt; ? &lt; -?/2.For (, ) in quadrant 4, -?/2 &lt; ? &lt; 0.For points on the
        ///     boundaries of the quadrants, the return value is the following:If y is 0 and x is not negative, ? = 0.If y is
        ///     0 and x is negative, ? = ?.If y is positive and x is 0, ? = ?/2.If y is negative and x is 0, ? = -?/2.If  or
        ///     is , or if  and  are either  or , the method returns .
        /// </returns>
        public static double Atan2(this double y, double x)
        {
            return Math.Atan2(y, x);
        }

        /// <summary>
        ///     计算切线为指定数字的角度。
        /// </summary>
        /// <param name="d">A number representing a tangent.</param>
        /// <returns>
        ///     An angle, ?, measured in radians, such that -?/2 ????/2.-or-  if  equals , -?/2 rounded to double precision (-
        ///     1.5707963267949) if  equals , or ?/2 rounded to double precision (1.5707963267949) if  equals .
        /// </returns>
        public static double Atan(this double d)
        {
            return Math.Atan(d);
        }

        /// <summary>
        ///    计算正弦值为指定数字的角度
        /// </summary>
        /// <param name="d">
        ///     A number representing a sine, where  must be greater than or equal to -1, but less than or equal
        ///     to 1.
        /// </param>
        /// <returns>
        ///     An angle, ?, measured in radians, such that -?/2 ????/2 -or-  if  &lt; -1 or  &gt; 1 or  equals .
        /// </returns>
        public static double Asin(this double d)
        {
            return Math.Asin(d);
        }

        /// <summary>
        ///     计算绝对值
        /// </summary>
        /// <param name="value">A number that is greater than or equal to , but less than or equal to .</param>
        /// <returns>A double-precision floating-point number, x, such that 0 ? x ?.</returns>
        public static double Abs(this double value)
        {
            return Math.Abs(value);
        }

        /// <summary>
        ///     计算余弦值为指定数字的角度。
        /// </summary>
        /// <param name="d">
        ///     A number representing a cosine, where  must be greater than or equal to -1, but less than or
        ///     equal to 1.
        /// </param>
        /// <returns>An angle, ?, measured in radians, such that 0 ????-or-  if  &lt; -1 or  &gt; 1 or  equals .</returns>
        public static double Acos(this double d)
        {
            return Math.Acos(d);
        }
    }
}

#endregion