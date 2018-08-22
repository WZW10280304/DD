using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using CYJ.DingDing.Dto.Dto;
using CYJ.DingDing.Dto.Dto.Base;
using CYJ.DingDing.Dto.Enum;
using Newtonsoft.Json;

namespace CYJ.DingDing.Infrastructure.Treasury
{
    /// <summary>
    /// 请求协助类
    /// </summary>
    public class RequestHelper
    {
        public static string GetAccessToken()
        {
            return "";
        }

        /// <summary>
        /// 执行基本的命令方法,以Get方式
        /// </summary>
        /// <param name="apiurl"></param>
        /// <returns></returns>
        public static string Get(string apiurl)
        {
            WebRequest request = WebRequest.Create(@apiurl);
            request.Method = "GET";
            WebResponse response = request.GetResponse();
            Stream stream = response.GetResponseStream();
            Encoding encode = Encoding.UTF8;
            StreamReader reader = new StreamReader(stream, encode);
            string resultJson = reader.ReadToEnd();
            return resultJson;
        }

        public static T Get<T>(string apiurl)
        {
            var result = Get(apiurl);

            var rtn = JsonConvert.DeserializeObject<T>(result);

            return rtn;
        }

        /// <summary>
        /// 以Post方式提交命令
        /// </summary>
        public static string Post(string apiurl, string jsonString)
        {
            WebRequest request = WebRequest.Create(@apiurl);
            request.Method = "POST";
            request.ContentType = "application/json";

            byte[] bs = Encoding.UTF8.GetBytes(jsonString);
            request.ContentLength = bs.Length;
            Stream newStream = request.GetRequestStream();
            newStream.Write(bs, 0, bs.Length);
            newStream.Close();

            WebResponse response = request.GetResponse();
            Stream stream = response.GetResponseStream();
            Encoding encode = Encoding.UTF8;
            StreamReader reader = new StreamReader(stream, encode);
            string resultJson = reader.ReadToEnd();
            return resultJson;
        }

        public static string Post(string apiurl, object obj)
        {
            var jsonString = JsonConvert.SerializeObject(obj);

            return Post(apiurl, jsonString);
        }

        public static T Post<T>(string apiurl, object obj)
        {
            var jsonString = JsonConvert.SerializeObject(obj);

            var result = Post(apiurl, jsonString);

            var rtn = JsonConvert.DeserializeObject<T>(result);

            return rtn;
        }
    }

}
