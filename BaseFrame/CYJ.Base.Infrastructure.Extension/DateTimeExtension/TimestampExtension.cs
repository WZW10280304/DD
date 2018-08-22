using System;

namespace CYJ.Utils.Extension.DateTimeExtension
{
    public static class TimestampExtension
    {
        #region Unix时间戳

        /// <summary>
        ///     把时间格式转换为Unix时间戳格式
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public static long GetUnixTimestamp(this DateTime time)
        {
            var startTime = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1)); // 当地时区
            var timeStamp = (long) (DateTime.Now - startTime).TotalSeconds; // 相差秒数
            return timeStamp;
        }

        /// <summary>
        ///     把Unix时间戳转化为时间
        /// </summary>
        /// <param name="unixTimeStamp"></param>
        /// <returns></returns>
        public static DateTime GetTimeByUnixTimestamp(this long unixTimeStamp)
        {
            var startTime = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1)); // 当地时区
            var dt = startTime.AddSeconds(unixTimeStamp);
            return dt;
        }

        #endregion


        #region  javascript时间戳

        /// <summary>
        ///     javascript时间戳转为C#格式时间
        /// </summary>
        /// <returns></returns>
        public static DateTime GetTimeByJsTimestamp(this long timeStamp)
        {
            var startTime = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1)); // 当地时区
            var dt = startTime.AddMilliseconds(timeStamp);
            return dt;
        }

        /// <summary>
        ///     把时间转换为javascript所使用的时间
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static long GetJsTimestamp(this DateTime dateTime)
        {
            var startTime = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1)); // 当地时区
            var timeStamp = (long) (dateTime - startTime).TotalMilliseconds; // 相差毫秒数
            return timeStamp;
        }

        #endregion
    }
}