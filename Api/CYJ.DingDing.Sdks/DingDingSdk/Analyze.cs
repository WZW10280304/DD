using System;
using CYJ.DingDing.Dto.Dto;
using CYJ.DingDing.Dto.Dto.Base;
using CYJ.DingDing.Infrastructure.Treasury;
using Newtonsoft.Json;

namespace CYJ.DingDing.Sdks.DingDingSdk
{
    /// <summary>
    /// 分析器
    /// </summary>
    public class Analyze
    {
        #region Get Function  
        /// <summary>
        /// 发起GET请求
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="requestUrl"></param>
        /// <returns></returns>
        public static T Get<T>(String requestUrl) where T : DingTalkResponse, new()
        {
            String resultJson = RequestHelper.Get(requestUrl);
            return AnalyzeResult<T>(resultJson);
        }
        #endregion

        #region Post Function
        /// <summary>
        /// 发起POST请求
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="requestUrl"></param>
        /// <param name="requestParamOfJsonStr"></param>
        /// <returns></returns>
        public static T Post<T>(String requestUrl, String requestParamOfJsonStr) where T : DingTalkResponse, new()
        {
            String resultJson = RequestHelper.Post(requestUrl, requestParamOfJsonStr);
            return AnalyzeResult<T>(resultJson);
        }
        #endregion

        #region AnalyzeResult
        /// <summary>
        /// 分析结果
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="resultJson"></param>
        /// <returns></returns>
        private static T AnalyzeResult<T>(string resultJson) where T : DingTalkResponse, new()
        {
            DingTalkResponse tempResult = null;
            if (!String.IsNullOrEmpty(resultJson))
            {
                tempResult = JsonConvert.DeserializeObject<DingTalkResponse>(resultJson);
            }
            T result = null;
            if (tempResult != null && tempResult.IsOk())
            {
                result = JsonConvert.DeserializeObject<T>(resultJson);
            }
            else if (tempResult != null)
            {
                result = tempResult as T;
            }
            else if (tempResult == null)
            {
                result = new T();
            }
            //result.Json = resultJson;
            return result;
        }
        #endregion      
    }

}
