using System;

// ReSharper disable once CheckNamespace
namespace Aquarium.Util.Extension.NumberExtension
{
    public static class DecimalExtension
    {
        /// <summary>
        ///     使用小数点分割两个decimal
        /// </summary>
        /// <param name="d1">The dividend.</param>
        /// <param name="d2">The divisor.</param>
        /// <returns>The result of dividing  by .</returns>
        public static decimal Divide(this decimal d1, decimal d2)
        {
            return decimal.Divide(d1, d2);
        }

        /// <summary>
        ///    转换为二进制表示形式。
        /// </summary>
        /// <param name="d">The value to convert.</param>
        /// <returns>A 32-bit signed integer array with four elements that contain the binary representation of .</returns>
        public static int[] GetBits(this decimal d)
        {
            return decimal.GetBits(d);
        }

    

  

        #region 类型转换  

        /// <summary>
        ///     Converts the value of the specified  to the equivalent 64-bit signed integer.
        /// </summary>
        /// <param name="d">The decimal number to convert.</param>
        /// <returns>A 64-bit signed integer equivalent to the value of .</returns>
        public static long ToLong(this decimal d)
        {
            return decimal.ToInt64(d);
        }

        /// <summary>
        ///     Converts the value of the specified  to the equivalent 8-bit unsigned integer.
        /// </summary>
        /// <param name="value">The decimal number to convert.</param>
        /// <returns>An 8-bit unsigned integer equivalent to .</returns>
        public static byte ToByte(this decimal value)
        {
            return decimal.ToByte(value);
        }

        /// <summary>
        ///     Converts the value of the specified  to the equivalent 32-bit signed integer.
        /// </summary>
        /// <param name="d">The decimal number to convert.</param>
        /// <returns>A 32-bit signed integer equivalent to the value of .</returns>
        public static int ToInt(this decimal d)
        {
            return decimal.ToInt32(d);
        }

        /// <summary>
        ///     Converts the value of the specified  to the equivalent single-precision floating-point number.
        /// </summary>
        /// <param name="d">The decimal number to convert.</param>
        /// <returns>A single-precision floating-point number equivalent to the value of .</returns>
        public static float ToSingle(this decimal d)
        {
            return decimal.ToSingle(d);
        }

        /// <summary>
        ///     Converts the value of the specified  to the equivalent 8-bit signed integer.
        /// </summary>
        /// <param name="value">The decimal number to convert.</param>
        /// <returns>An 8-bit signed integer equivalent to .</returns>
        public static sbyte ToSByte(this decimal value)
        {
            return decimal.ToSByte(value);
        }

        /// <summary>
        ///     Converts the value of the specified  to the equivalent 16-bit signed integer.
        /// </summary>
        /// <param name="value">The decimal number to convert.</param>
        /// <returns>A 16-bit signed integer equivalent to .</returns>
        public static short ToShort(this decimal value)
        {
            return decimal.ToInt16(value);
        }

        /// <summary>
        ///     Converts the value of the specified  to the equivalent double-precision floating-point number.
        /// </summary>
        /// <param name="d">The decimal number to convert.</param>
        /// <returns>A double-precision floating-point number equivalent to .</returns>
        public static double ToDouble(this decimal d)
        {
            return decimal.ToDouble(d);
        }

        #endregion、

        #region 计算

        /// <summary>
        ///     余数计算
        /// </summary>
        /// <param name="d1">The dividend.</param>
        /// <param name="d2">The divisor.</param>
        /// <returns>The remainder after dividing  by .</returns>
        public static decimal Remainder(this decimal d1, decimal d2)
        {
            return decimal.Remainder(d1, d2);
        }

        /// <summary>
        ///    取负值
        /// </summary>
        /// <param name="d">The value to negate.</param>
        /// <returns>A decimal number with the value of , but the opposite sign.-or- Zero, if  is zero.</returns>
        public static decimal Negate(this decimal d)
        {
            return decimal.Negate(d);
        }
        /// <summary>
        ///     取绝对值.
        /// </summary>
        /// <param name="value">A number that is greater than or equal to , but less than or equal to .</param>
        /// <returns>A decimal number, x, such that 0 ? x ?.</returns>
        public static decimal Abs(this decimal value)
        {
            return Math.Abs(value);
        }

        /// <summary>
        ///     向上取整
        /// </summary>
        /// <param name="d">A decimal number.</param>
        /// <returns>
        ///     The smallest integral value that is greater than or equal to . Note that this method returns a  instead of an
        ///     integral type.
        /// </returns>
        public static decimal Ceiling(this decimal d)
        {
            return Math.Ceiling(d);
        }

        /// <summary>
        ///     取最小值
        /// </summary>
        /// <param name="val1">The first of two decimal numbers to compare.</param>
        /// <param name="val2">The second of two decimal numbers to compare.</param>
        /// <returns>Parameter  or , whichever is smaller.</returns>
        public static decimal Min(this decimal val1, decimal val2)
        {
            return Math.Min(val1, val2);
        }

        /// <summary>
        ///     取最大值
        /// </summary>
        /// <param name="val1">The first of two decimal numbers to compare.</param>
        /// <param name="val2">The second of two decimal numbers to compare.</param>
        /// <returns>Parameter  or , whichever is larger.</returns>
        public static decimal Max(this decimal val1, decimal val2)
        {
            return Math.Max(val1, val2);
        }

        /// <summary>
        ///     向下取整
        /// </summary>
        /// <param name="d">A decimal number.</param>
        /// <returns>
        ///     The largest integer less than or equal to .  Note that the method returns an integral value of type .
        /// </returns>
        public static decimal Floor(this decimal d)
        {
            return Math.Floor(d);
        }


        /// <summary>
        ///     四舍五入保留小数点
        /// </summary>
        /// <param name="d">A decimal number to be rounded.</param>
        /// <returns>
        ///     The integer nearest parameter . If the fractional component of  is halfway between two integers, one of which
        ///     is even and the other odd, the even number is returned. Note that this method returns a  instead of an
        ///     integral type.
        /// </returns>
        public static decimal Round(this decimal d)
        {
            return Math.Round(d, MidpointRounding.AwayFromZero);
        }

        /// <summary>
        ///     四舍五入保留小数点
        /// </summary>
        /// <param name="d">A decimal number to be rounded.</param>
        /// <param name="decimals">The number of decimal places in the return value.</param>
        /// <returns>The number nearest to  that contains a number of fractional digits equal to .</returns>
        public static decimal Round(this decimal d, int decimals)
        {
            return Math.Round(d, decimals, MidpointRounding.AwayFromZero);
        }

        /// <summary>
        ///     四舍五入保留小数点
        /// </summary>
        /// <param name="d">A decimal number to be rounded.</param>
        /// <param name="mode">Specification for how to round  if it is midway between two other numbers.</param>
        /// <returns>
        ///     The integer nearest . If  is halfway between two numbers, one of which is even and the other odd, then
        ///     determines which of the two is returned.
        /// </returns>
        public static decimal Round(this decimal d, MidpointRounding mode)
        {
            return Math.Round(d, mode);
        }

        /// <summary>
        ///    四舍五入保留小数点
        /// </summary>
        /// <param name="d">A decimal number to be rounded.</param>
        /// <param name="decimals">The number of decimal places in the return value.</param>
        /// <param name="mode">Specification for how to round  if it is midway between two other numbers.</param>
        /// <returns>
        ///     The number nearest to  that contains a number of fractional digits equal to . If  has fewer fractional digits
        ///     than ,  is returned unchanged.
        /// </returns>
        public static decimal Round(this decimal d, int decimals, MidpointRounding mode)
        {
            return Math.Round(d, decimals, mode);
        }

        /// <summary>
        ///    获取整数部分数值
        /// </summary>
        /// <param name="d">A number to truncate.</param>
        /// <returns>
        ///     The integral part of ; that is, the number that remains after any fractional digits have been discarded.
        /// </returns>
        public static decimal Truncate(this decimal d)
        {
            return Math.Truncate(d);
        }

        #endregion

        #region 金额格式化

        /// <summary>
        ///     金钱的格式化
        /// </summary>
        /// <param name="money">金额</param>
        /// <param name="moneyType">格式化字符串</param>
        /// <returns></returns>
        public static string GetMoneyString(this decimal? money, string moneyType = null)
        {
            if (!money.HasValue) return null;
            return moneyType == null ? money.ToString() : money.Value.ToString(moneyType);
        }

        /// <summary>
        ///     转换人民币汉字显示大小金额
        /// </summary>
        /// <param name="money">金额</param>
        /// <returns>返回大写形式</returns>
        public static string GetChineseMoneyString(this decimal? money)
        {
            if (!money.HasValue) return null;
            const string str1 = "零壹贰叁肆伍陆柒捌玖"; //0-9所对应的汉字
            var str2 = "万仟佰拾亿仟佰拾万仟佰拾元角分"; //数字位所对应的汉字
            var str5 = ""; //人民币大写金额形式
            int i; //循环变量
            var ch2 = "";
            var nzero = 0; //用来计算连续的零值是几个

            money = Math.Round(Math.Abs(money.Value), 2); //将num取绝对值并四舍五入取2位小数
            var str4 = ((long) (money * 100)).ToString();
            var j = str4.Length;
            if (j > 15) return "溢出";
            str2 = str2.Substring(15 - j); //取出对应位数的str2的值。如：200.55,j为5所以str2=佰拾元角分

            //循环取出每一位需要转换的值
            for (i = 0; i < j; i++)
            {
                var str3 = str4.Substring(i, 1); //从原num值中取出的值
                var temp = Convert.ToInt32(str3); //从原num值中取出的值
                var ch1 = ""; //数字的汉语读法
                if (i != j - 3 && i != j - 7 && i != j - 11 && i != j - 15)
                {
                    //当所取位数不为元、万、亿、万亿上的数字时
                    if (str3 == "0")
                    {
                        ch1 = "";
                        ch2 = "";
                        nzero = nzero + 1;
                    }
                    else
                    {
                        if (str3 != "0" && nzero != 0)
                        {
                            ch1 = "零" + str1.Substring(temp * 1, 1);
                            ch2 = str2.Substring(i, 1);
                            nzero = 0;
                        }
                        else
                        {
                            ch1 = str1.Substring(temp * 1, 1);
                            ch2 = str2.Substring(i, 1);
                            nzero = 0;
                        }
                    }
                }
                else
                {
                    //该位是万亿，亿，万，元位等关键位
                    if (str3 != "0" && nzero != 0)
                    {
                        ch1 = "零" + str1.Substring(temp * 1, 1);
                        ch2 = str2.Substring(i, 1);
                        nzero = 0;
                    }
                    else
                    {
                        if (str3 != "0" && nzero == 0)
                        {
                            ch1 = str1.Substring(temp * 1, 1);
                            ch2 = str2.Substring(i, 1);
                            nzero = 0;
                        }
                        else
                        {
                            if (str3 == "0" && nzero >= 3)
                            {
                                ch1 = "";
                                ch2 = "";
                                nzero = nzero + 1;
                            }
                            else
                            {
                                if (j >= 11)
                                {
                                    ch1 = "";
                                    nzero = nzero + 1;
                                }
                                else
                                {
                                    ch1 = "";
                                    ch2 = str2.Substring(i, 1);
                                    nzero = nzero + 1;
                                }
                            }
                        }
                    }
                }

                if (i == j - 11 || i == j - 3) ch2 = str2.Substring(i, 1);
                str5 = str5 + ch1 + ch2;

                if (i == j - 1 && str3 == "0") str5 = str5 + '整';
            }

            if (money == 0) str5 = "零元整";
            return str5;
        }

        #endregion 金额格式化
    }
}