using System;
using System.Collections.Specialized;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Web;

// ReSharper disable once CheckNamespace
namespace Aquarium.Util.Extension
{
    public static class NetExtension
    {
        /// <summary>
        ///     判断端口是否被占用
        /// </summary>
        /// <param name="port"></param>
        /// <returns></returns>
        public static bool IsPortInUse(this int port)
        {
            var ipProperties = IPGlobalProperties.GetIPGlobalProperties();
            var ipEndPoints = ipProperties.GetActiveTcpListeners();
            return ipEndPoints.Any(endPoint => endPoint.Port == port);
        }


        /// <summary>
        ///     Parses a query string into a  using  encoding.
        /// </summary>
        /// <param name="query">The query string to parse.</param>
        /// <returns>A  of query parameters and values.</returns>
        public static NameValueCollection ParseQueryString(this string query)
        {
            return HttpUtility.ParseQueryString(query);
        }

        /// <summary>
        ///     Parses a query string into a  using the specified .
        /// </summary>
        /// <param name="query">The query string to parse.</param>
        /// <param name="encoding">The  to use.</param>
        /// <returns>A  of query parameters and values.</returns>
        public static NameValueCollection ParseQueryString(this string query, Encoding encoding)
        {
            return HttpUtility.ParseQueryString(query, encoding);
        }


        /// <summary>
        ///     将对象转换为GET请求时的参数
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static string ToQueryString(this object parameters)
        {
            var querystring = "";
            var i = 0;
            try
            {
                foreach (var property in parameters.GetType().GetProperties())
                {
                    querystring += property.Name + "=" +
                                   Uri.EscapeDataString(property.GetValue(parameters, null).ToString());
                    if (++i < parameters.GetType().GetProperties().Length) querystring += "&";
                }
            }
            catch (NullReferenceException e)
            {
                throw new ArgumentNullException("Paramters cannot be a null object", e);
            }

            return querystring;
        }
    }
}