using System;
using System.Globalization;
using System.Text.RegularExpressions;
using Aquarium.Util.Extension.DateTimeExtension;
using Aquarium.Util.Extension.StringExtension;

namespace CYJ.Utils.Extension.StringExtension
{
    /// <summary>
    ///     常用正则表达式判断
    /// </summary>
// ReSharper disable once CheckNamespace
    public static class RegexExtension
    {
        /// <summary>
        ///     检查一个字符串是否是数值(开头不为0)
        /// </summary>
        /// <param name="this">需验证的字符串</param>
        /// <param name="this"></param>
        /// <returns>是否合法的bool值。</returns>
        public static bool IsValidNumber(this string @this)
        {
            return @this.IsMatch("^[1-9]*[0-9]*$");
        }

        /// <summary>
        ///     判断字符串是否符合email的正则
        /// </summary>
        /// <param name="obj">The obj to act on.</param>
        /// <returns>true if valid email, false if not.</returns>
        public static bool IsValidEmail(this string obj)
        {
            return Regex.IsMatch(obj,
                @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z0-9]{1,30})(\]?)$");
        }

        /// <summary>
        ///     判断字符串是否符合Ip4的正则
        /// </summary>
        /// <param name="obj">The obj to act on.</param>
        /// <returns>true if valid ip, false if not.</returns>
        public static bool IsValidIp(this string obj)
        {
            return Regex.IsMatch(obj,
                @"^(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9])\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[0-9])$");
        }

        /// <summary>
        ///     判断字符串是否符合身份证的正则
        /// </summary>
        /// <param name="cid"></param>
        /// <returns>true if valid ip, false if not.</returns>
        public static bool IsIdCard(this string cid)
        {
            string[] aCity =
            {
                null, null, null, null, null, null, null, null, null, null, null, "北京", "天津", "河北", "山西", "内蒙古", null, null,
                null, null, null, "辽宁", "吉林", "黑龙江", null, null, null, null, null, null, null, "上海", "江苏", "浙江", "安微", "福建",
                "江西", "山东", null, null, null, "河南", "湖北", "湖南", "广东", "广西", "海南", null, null, null, "重庆", "四川", "贵州", "云南",
                "西藏", null, null, null, null, null, null, "陕西", "甘肃", "青海", "宁夏", "新疆", null, null, null, null, null, "台湾",
                null, null, null, null, null, null, null, null, null, "香港", "澳门", null, null, null, null, null, null, null,
                null, "国外"
            };
            double iSum = 0;
            var rg = new Regex(@"^\d{17}(\d|x|X)$");
            var mc = rg.Match(cid);
            if (!mc.Success) return false;
            cid = cid.ToLower();
            cid = cid.Replace("x", "a");
            if (aCity[int.Parse(cid.Substring(0, 2))] == null) return false;
            try
            {
                (cid.Substring(6, 4) + "-" + cid.Substring(10, 2) + "-" + cid.Substring(12, 2)).ToDateTime();
            }
            catch
            {
                return false;
            }

            for (var i = 17; i >= 0; i--)
                iSum += Math.Pow(2, i) % 11 * int.Parse(cid[17 - i].ToString(), NumberStyles.HexNumber);
            return iSum % 11 == 1;
        }

        /// <summary>
        ///     判断输入的字符串是否是一个合法的手机号
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsMobilePhone(string input)
        {
            var regex = new Regex("^1[34578]\\d{9}$");
            return regex.IsMatch(input);
        }
    }
}