using System;
using System.Diagnostics;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CYJ.Base.Service.Http.Filters
{
    public class BaseActionFilterAttribute : ActionFilterAttribute
    {
        private Stopwatch _stopWatch;
        private StringBuilder _sbLogger;

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            _sbLogger = new StringBuilder();
            _stopWatch = new Stopwatch();
            _stopWatch.Start();
            //日志基本信息
            //var urlPath = context.HttpContext.Request.Path;
            //var method = context.HttpContext.Request.Method;
            //var body = HttpContextHelper.GetJsonRequestBody(context.HttpContext);
            //var parmas = context.HttpContext.Request.Query.Select(m => m.Key + "=" + m.Value).ToList();
            //var query = string.Join(",", parmas);
            ////日志StringBuilder
            //_sbLogger.AppendLine($"Url请求地址：{urlPath}");
            //_sbLogger.AppendLine($"请求方式：{method}");
            //_sbLogger.AppendLine($"请求的Query：{query}");
            //_sbLogger.AppendLine($"请求Json入参：{body}");
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            _stopWatch.Stop();
            var time = _stopWatch.Elapsed.TotalMilliseconds;
            //var resultData = GetActionResult(context, out var isIgnoreResult);
            //if (!isIgnoreResult)
            //{
            //    var model = new ApiResult(ApiResultCode.Success) { Data = resultData };
            //    var returnMsg = model.ToJson();
            //    var result = new ContentResult
            //    {
            //        StatusCode = 200,
            //        ContentType = "application/json",
            //        Content = returnMsg
            //    };
            //    context.Result = result;
            //    _sbLogger.AppendLine($"出参：{returnMsg}");
            //    _sbLogger.AppendLine($"耗时：{time}毫秒");

            //    //todo:添加日志
            //    //AquariumLogManager.GetInstance().Info(_sbLogger.ToString(), tags: "BaseApiActionFilterAttribute");
            //}
        }

        /// <summary>
        /// 核心的验证处理逻辑
        /// </summary>
        /// <param name="context">上下文</param>
        /// <param name="isIgnoreResult"></param>
        /// <returns></returns>
        private object GetActionResult(ActionExecutedContext context, out bool isIgnoreResult)
        {
            isIgnoreResult = false;
            if (context.Result is ObjectResult objectResult)
            {
                return objectResult.Value;
            }
            if (context.Result is ContentResult contentResult)
            {
                return contentResult.Content;
            }
            if (context.Result is JsonResult jsonResult)
            {
                return jsonResult.Value;
            }
            //数据流、视图之类的不进行处理
            isIgnoreResult = true;
            return null;
        }
    }
}
