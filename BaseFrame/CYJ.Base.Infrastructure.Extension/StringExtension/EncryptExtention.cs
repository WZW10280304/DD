using System;
using System.IO;
using System.Text;
using System.Web;

// ReSharper disable once CheckNamespace
namespace Aquarium.Util.Extension.StringExtension
{
    public static class EncryptExtention
    {
        #region Url

        /// <summary>
        ///     使用指定的解码对象将 URL 编码的字节数组转换为已解码的字符串。
        /// </summary>
        /// <param name="bytes">The array of bytes to decode.</param>
        /// <param name="e">The  that specifies the decoding scheme.</param>
        /// <returns>A decoded string.</returns>
        public static string UrlDecode(this byte[] bytes, Encoding e)
        {
            return HttpUtility.UrlDecode(bytes, e);
        }

        /// <summary>
        ///     Converts a URL-encoded array of bytes into a decoded array of bytes.
        /// </summary>
        /// <param name="bytes">The array of bytes to decode.</param>
        /// <returns>A decoded array of bytes.</returns>
        public static byte[] UrlDecodeToBytes(this byte[] bytes)
        {
            return HttpUtility.UrlDecodeToBytes(bytes);
        }

        /// <summary>
        ///     Converts a byte array into an encoded URL string.
        /// </summary>
        /// <param name="bytes">The array of bytes to encode.</param>
        /// <returns>An encoded string.</returns>
        public static string UrlEncode(this byte[] bytes)
        {
            return HttpUtility.UrlEncode(bytes);
        }

        /// <summary>
        ///     将字节数组转换为 URL 编码的字节数组。
        /// </summary>
        /// <param name="bytes">The array of bytes to encode.</param>
        /// <returns>An encoded array of bytes.</returns>
        public static byte[] UrlEncodeToBytes(this byte[] bytes)
        {
            return HttpUtility.UrlEncodeToBytes(bytes);
        }

        /// <summary>
        ///     Converts an array of bytes into a URL-encoded array of bytes, starting at the specified position in the array
        ///     and continuing for the specified number of bytes.
        /// </summary>
        /// <param name="bytes">The array of bytes to encode.</param>
        /// <param name="offset">The position in the byte array at which to begin encoding.</param>
        /// <param name="count">The number of bytes to encode.</param>
        /// <returns>An encoded array of bytes.</returns>
        public static byte[] UrlEncodeToBytes(this byte[] bytes, int offset, int count)
        {
            return HttpUtility.UrlEncodeToBytes(bytes, offset, count);
        }

        /// <summary>
        ///     Converts a byte array into a URL-encoded string, starting at the specified position in the array and
        ///     continuing for the specified number of bytes.
        /// </summary>
        /// <param name="bytes">The array of bytes to encode.</param>
        /// <param name="offset">The position in the byte array at which to begin encoding.</param>
        /// <param name="count">The number of bytes to encode.</param>
        /// <returns>An encoded string.</returns>
        public static string UrlEncode(this byte[] bytes, int offset, int count)
        {
            return HttpUtility.UrlEncode(bytes, offset, count);
        }

        /// <summary>
        ///     Converts a URL-encoded array of bytes into a decoded array of bytes, starting at the specified position in
        ///     the array and continuing for the specified number of bytes.
        /// </summary>
        /// <param name="bytes">The array of bytes to decode.</param>
        /// <param name="offset">The position in the byte array at which to begin decoding.</param>
        /// <param name="count">The number of bytes to decode.</param>
        /// <returns>A decoded array of bytes.</returns>
        public static byte[] UrlDecodeToBytes(this byte[] bytes, int offset, int count)
        {
            return HttpUtility.UrlDecodeToBytes(bytes, offset, count);
        }

        /// <summary>
        ///     Converts a URL-encoded byte array into a decoded string using the specified encoding object, starting at the
        ///     specified position in the array, and continuing for the specified number of bytes.
        /// </summary>
        /// <param name="bytes">The array of bytes to decode.</param>
        /// <param name="offset">The position in the byte to begin decoding.</param>
        /// <param name="count">The number of bytes to decode.</param>
        /// <param name="e">The  object that specifies the decoding scheme.</param>
        /// <returns>A decoded string.</returns>
        public static string UrlDecode(this byte[] bytes, int offset, int count, Encoding e)
        {
            return HttpUtility.UrlDecode(bytes, offset, count, e);
        }

        /// <summary>
        ///     对 URL 字符串的路径部分进行编码, 以便从 Web 服务器到客户端进行可靠的 HTTP 传输。
        /// </summary>
        /// <param name="str">The text to encode.</param>
        /// <returns>The encoded text.</returns>
        public static string UrlPathEncode(this string str)
        {
            return HttpUtility.UrlPathEncode(str);
        }

        /// <summary>
        ///     Converts a string into a URL-encoded array of bytes.
        /// </summary>
        /// <param name="str">The string to encode.</param>
        /// <returns>An encoded array of bytes.</returns>
        public static byte[] EncodeUrlToBytes(this string str)
        {
            return HttpUtility.UrlEncodeToBytes(str);
        }

        /// <summary>
        ///     Converts a string into a URL-encoded array of bytes using the specified encoding object.
        /// </summary>
        /// <param name="str">The string to encode.</param>
        /// <param name="e">The  that specifies the encoding scheme.</param>
        /// <returns>An encoded array of bytes.</returns>
        public static byte[] EncodeUrlToBytes(this string str, Encoding e)
        {
            return HttpUtility.UrlEncodeToBytes(str, e);
        }

        /// <summary>
        ///     Encodes a URL string.
        /// </summary>
        /// <param name="str">The text to encode.</param>
        /// <returns>An encoded string.</returns>
        public static string UrlEncode(this string str)
        {
            return HttpUtility.UrlEncode(str);
        }

        /// <summary>
        ///     Encodes a URL string using the specified encoding object.
        /// </summary>
        /// <param name="str">The text to encode.</param>
        /// <param name="e">The  object that specifies the encoding scheme.</param>
        /// <returns>An encoded string.</returns>
        public static string UrlEncode(this string str, Encoding e)
        {
            return HttpUtility.UrlEncode(str, e);
        }

        /// <summary>
        ///     Converts a URL-encoded string into a decoded array of bytes.
        /// </summary>
        /// <param name="str">The string to decode.</param>
        /// <returns>A decoded array of bytes.</returns>
        public static byte[] UrlToBytesDecode(this string str)
        {
            return HttpUtility.UrlDecodeToBytes(str);
        }

        /// <summary>
        ///     Converts a URL-encoded string into a decoded array of bytes using the specified decoding object.
        /// </summary>
        /// <param name="str">The string to decode.</param>
        /// <param name="e">The  object that specifies the decoding scheme.</param>
        /// <returns>A decoded array of bytes.</returns>
        public static byte[] UrlToBytesDecode(this string str, Encoding e)
        {
            return HttpUtility.UrlDecodeToBytes(str, e);
        }

        /// <summary>
        ///    将已编码为在 URL 中传输的字符串转换为已解码的字符串。
        /// </summary>
        /// <param name="str">The string to decode.</param>
        /// <returns>A decoded string.</returns>
        public static string UrlDecode(this string str)
        {
            return HttpUtility.UrlDecode(str);
        }

        /// <summary>
        ///     Converts a URL-encoded string into a decoded string, using the specified encoding object.
        /// </summary>
        /// <param name="str">The string to decode.</param>
        /// <param name="e">The  that specifies the decoding scheme.</param>
        /// <returns>A decoded string.</returns>
        public static string UrlDecode(this string str, Encoding e)
        {
            return HttpUtility.UrlDecode(str, e);
        }

        #endregion

        #region JavaScript

        /// <summary>
        ///     Encodes a string.
        /// </summary>
        /// <param name="value">A string to encode.</param>
        /// <returns>An encoded string.</returns>
        public static string JsEncode(this string value)
        {
            return HttpUtility.JavaScriptStringEncode(value);
        }

        /// <summary>
        ///     Encodes a string.
        /// </summary>
        /// <param name="value">A string to encode.</param>
        /// <param name="addDoubleQuotes">
        ///     A value that indicates whether double quotation marks will be included around the
        ///     encoded string.
        /// </param>
        /// <returns>An encoded string.</returns>
        public static string JsEncode(this string value, bool addDoubleQuotes)
        {
            return HttpUtility.JavaScriptStringEncode(value, addDoubleQuotes);
        }

        #endregion

        #region Html

        /// <summary>
        ///   将字符串转换为 HTML 编码的字符串。 ...
        /// </summary>
        /// <param name="s">The string to encode.</param>
        /// <returns>An encoded string.</returns>
        public static string HtmlEncode(this string s)
        {
            return HttpUtility.HtmlEncode(s);
        }

        /// <summary>
        ///     Converts a string into an HTML-encoded string, and returns the output as a  stream of output.
        /// </summary>
        /// <param name="s">The string to encode.</param>
        /// <param name="output">A  output stream.</param>
        public static void HtmlEncode(this string s, TextWriter output)
        {
            HttpUtility.HtmlEncode(s, output);
        }

        /// <summary>
        ///    将字符串最小转换为 HTML 编码的字符串。
        /// </summary>
        /// <param name="s">The string to encode.</param>
        /// <returns>An encoded string.</returns>
        public static string HtmlAttributeEncode(this string s)
        {
            return HttpUtility.HtmlAttributeEncode(s);
        }

        /// <summary>
        ///     Minimally converts a string into an HTML-encoded string and sends the encoded string to a  output stream.
        /// </summary>
        /// <param name="s">The string to encode.</param>
        /// <param name="output">A  output stream.</param>
        public static void HtmlAttributeEncode(this string s, TextWriter output)
        {
            HttpUtility.HtmlAttributeEncode(s, output);
        }

        /// <summary>
        ///     将已为 HTTP 传输的 HTML 编码的字符串转换为已解码的字符串。
        /// </summary>
        /// <param name="s">The string to decode.</param>
        /// <returns>A decoded string.</returns>
        public static string HtmlDecode(this string s)
        {
            return HttpUtility.HtmlDecode(s);
        }

        /// <summary>
        ///     Converts a string that has been HTML-encoded into a decoded string, and sends the decoded string to a  output
        ///     stream.
        /// </summary>
        /// <param name="s">The string to decode.</param>
        /// <param name="output">A  stream of output.</param>
        public static void HtmlDecode(this string s, TextWriter output)
        {
            HttpUtility.HtmlDecode(s, output);
        }

        #endregion

        #region Base64

        /// <summary>
        ///    将字符串编码为 Base64 的字符串扩展方法。
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="encoding"></param>
        /// <returns>The encoded string to Base64.</returns>
        public static string Base64Encode(this string @this, Encoding encoding = null)
        {
            if (encoding == null)
                encoding = Encoding.UTF8;
            return Convert.ToBase64String(encoding.GetBytes(@this));
        }

        /// <summary>
        ///    解码 Base64 字符串的字符串
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="encoding"></param>
        /// <returns>The Base64 String decoded.</returns>
        public static string Base64Decode(this string @this, Encoding encoding = null)
        {
            if (encoding == null)
                encoding = Encoding.UTF8;
            return encoding.GetString(Convert.FromBase64String(@this));
        }

        /// <summary>
        ///     将Byte数组转成base64字符串
        /// </summary>
        /// <param name="bytes">要转换的字节数组</param>
        /// <returns>返回转换后的字符串</returns>
        public static string Base64Encode(this byte[] bytes)
        {
            return Convert.ToBase64String(bytes);
        }


        /// <summary>
        ///     将8位无符号整数数组的子集转换为 Unicode 字符数组的等效子集
        ///     用 base-64 数字编码。参数将子集指定为输入和输出数组中的偏移量, 则
        ///     要转换的输入数组中的元素数, 以及是否在输出数组中插入换行符。
        /// </summary>
        /// <param name="inArray">An input array of 8-bit unsigned integers.</param>
        /// <param name="offsetIn">A position within .</param>
        /// <param name="length">The number of elements of  to convert.</param>
        /// <param name="outArray">An output array of Unicode characters.</param>
        /// <param name="offsetOut">A position within .</param>
        /// <param name="options">to insert a line break every 76 characters, or  to not insert line breaks.</param>
        /// <returns>A 32-bit signed integer containing the number of bytes in .</returns>
        public static int ToBase64CharArray(this byte[] inArray, int offsetIn, int length, char[] outArray, int offsetOut,
            Base64FormattingOptions options)
        {
            return Convert.ToBase64CharArray(inArray, offsetIn, length, outArray, offsetOut, options);
        }

   

        /// <summary>
        ///     Converts an array of 8-bit unsigned integers to its equivalent string representation that is encoded with
        ///     base-64 digits. A parameter specifies whether to insert line breaks in the return value.
        /// </summary>
        /// <param name="inArray">An array of 8-bit unsigned integers.</param>
        /// <param name="options">to insert a line break every 76 characters, or  to not insert line breaks.</param>
        /// <returns>The string representation in base 64 of the elements in .</returns>
        public static string Base64Encode(this byte[] inArray, Base64FormattingOptions options)
        {
            return Convert.ToBase64String(inArray, options);
        }

        /// <summary>
        ///     Converts a subset of an array of 8-bit unsigned integers to its equivalent string representation that is
        ///     encoded with base-64 digits. Parameters specify the subset as an offset in the input array, and the number of
        ///     elements in the array to convert.
        /// </summary>
        /// <param name="inArray">An array of 8-bit unsigned integers.</param>
        /// <param name="offset">An offset in .</param>
        /// <param name="length">The number of elements of  to convert.</param>
        /// <returns>The string representation in base 64 of  elements of , starting at position .</returns>
        public static string Base64Encode(this byte[] inArray, int offset, int length)
        {
            return Convert.ToBase64String(inArray, offset, length);
        }

        /// <summary>
        ///     Converts a subset of an 8-bit unsigned integer array to an equivalent subset of a Unicode character array
        ///     encoded with base-64 digits. Parameters specify the subsets as offsets in the input and output arrays, and
        ///     the number of elements in the input array to convert.
        /// </summary>
        /// <param name="inArray">An input array of 8-bit unsigned integers.</param>
        /// <param name="offsetIn">A position within .</param>
        /// <param name="length">The number of elements of  to convert.</param>
        /// <param name="outArray">An output array of Unicode characters.</param>
        /// <param name="offsetOut">A position within .</param>
        /// <returns>A 32-bit signed integer containing the number of bytes in .</returns>
        public static int ToBase64CharArray(this byte[] inArray, int offsetIn, int length, char[] outArray, int offsetOut)
        {
            return Convert.ToBase64CharArray(inArray, offsetIn, length, outArray, offsetOut);
        }

        #endregion
    }
}