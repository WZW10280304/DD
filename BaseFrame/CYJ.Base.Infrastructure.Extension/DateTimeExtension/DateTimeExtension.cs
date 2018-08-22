using System;
using System.Globalization;
using Aquarium.Util.Extension.StringExtension;

// ReSharper disable CheckNamespace

namespace Aquarium.Util.Extension.DateTimeExtension
{
    public static class DateTimeExtension
    {
        #region 时间计算

        /// <summary>
        ///     获取以0点0分0秒开始的日期
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static DateTime GetStartDateTime(this DateTime @this)
        {
            var result = @this;
            if (@this.Hour == 0) return result;
            var year = @this.Year;
            var month = @this.Month;
            var day = @this.Day;
            const string hour = "0";
            const string minute = "0";
            const string second = "0";
            result = Convert.ToDateTime(string.Format("{0}-{1}-{2} {3}:{4}:{5}", year, month, day, hour, minute,
                second));

            return result;
        }

        /// <summary>
        ///     获取以23点59分59秒结束的日期
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static DateTime GetEndDateTime(this DateTime @this)
        {
            var result = @this;
            if (@this.Hour == 23) return result;
            var year = @this.Year;
            var month = @this.Month;
            var day = @this.Day;
            const string hour = "23";
            const string minute = "59";
            const string second = "59";
            result = Convert.ToDateTime(string.Format("{0}-{1}-{2} {3}:{4}:{5}", year, month, day, hour, minute,
                second));
            return result;
        }


        /// <summary>
        ///     根据出生日期获取年龄
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>An int.</returns>
        public static int GetAge(this DateTime @this)
        {
            if (DateTime.Today.Month < @this.Month ||
                DateTime.Today.Month == @this.Month &&
                DateTime.Today.Day < @this.Day)
                return DateTime.Today.Year - @this.Year - 1;
            return DateTime.Today.Year - @this.Year;
        }


        /// <summary>
        ///     返回时间的格式化，如果是当天，则返回上午，下午，晚上，凌晨，
        ///     根据format将时间转换成string
        ///     如果format为空，则默认返回yyyy/MM/dd
        /// </summary>
        /// <param name="dateTime">需要准换的时间</param>
        /// <param name="format">格式化</param>
        /// <returns></returns>
        public static string GetDateString(this DateTime? dateTime, string format = null)
        {
            if (dateTime == null)
                return string.Empty;
            if (dateTime.Value.Date.Equals(DateTime.Now.Date))
            {
                if (dateTime.Value.Hour >= 6 && dateTime.Value.Hour < 12)
                    return "上午 " + dateTime.Value.ToString("hh:mm:ss");
                if (dateTime.Value.Hour >= 12 && dateTime.Value.Hour < 18)
                    return "下午 " + dateTime.Value.ToString("hh:mm:ss");
                if (dateTime.Value.Hour >= 18 && dateTime.Value.Hour < 24)
                    return "晚上 " + dateTime.Value.ToString("hh:mm:ss");
                if (dateTime.Value.Hour >= 0 && dateTime.Value.Hour < 6)
                    return "凌晨 " + dateTime.Value.ToString("hh:mm:ss");
            }
            else
            {
                return dateTime.ToString(format);
            }

            return string.Empty;
        }

        #endregion


        #region 类型转换

        /// <summary>
        ///     将string转换为datetime
        /// </summary>
        /// <param name="dateTimeStr">时间字符串</param>
        /// <returns></returns>
        public static DateTime? ToDateTime(this string dateTimeStr)
        {
            if (dateTimeStr.IsNullOrWhiteSpace())
                return null;
            return Convert.ToDateTime(dateTimeStr);
        }

        /// <summary>
        ///     将string转换为datetime
        /// </summary>
        /// <param name="dateTimeStr">时间字符串</param>
        /// <param name="format"></param>
        /// <returns></returns>
        public static DateTime? ToDateTime(this string dateTimeStr, string format)
        {
            if (dateTimeStr.IsNullOrWhiteSpace())
                return null;

            if (format.IsNullOrWhiteSpace())
                return Convert.ToDateTime(dateTimeStr);

            return DateTime.ParseExact(dateTimeStr, format, CultureInfo.CurrentCulture);
        }

        /// <summary>
        ///     根据format将时间转换成string
        ///     如果format为空，则默认返回yyyy/MM/dd
        /// </summary>
        /// <param name="dateTime">需要转换的时间</param>
        /// <param name="format">格式化</param>
        /// <returns></returns>
        public static string ToString(this DateTime? dateTime, string format = "yyyy/MM/dd HH:mm:sss")
        {
            return dateTime?.ToString(format);
        }

        /// <summary>
        ///     格式化时间字符
        /// </summary>
        /// <param name="dateTime"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        public static string ToString(this DateTime dateTime, string format = "yyyy/MM/dd HH:mm:sss")
        {
            return new DateTime?(dateTime).ToString(format);
        }

        #endregion

        #region 时间判定

        /// <summary>
        ///     是否是当前日期
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>true if today, false if not.</returns>
        public static bool IsToday(this DateTime @this)
        {
            return @this.Date == DateTime.Today;
        }

        /// <summary>
        ///     是否是过去时间
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>true if the value is in the past, false if not.</returns>
        public static bool IsPast(this DateTime @this)
        {
            return @this < DateTime.Now;
        }

        #endregion
    }
}