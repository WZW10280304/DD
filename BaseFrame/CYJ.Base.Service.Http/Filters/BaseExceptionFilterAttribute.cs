using System;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CYJ.Base.Service.Http.Filters
{
    public class BaseExceptionFilterAttribute : ExceptionFilterAttribute, IExceptionFilter
    {
        public override void OnException(ExceptionContext context)
        {
            ProcessException(context);
        }

        public override Task OnExceptionAsync(ExceptionContext context)
        {
            return ProcessException(context);
        }

        private Task ProcessException(ExceptionContext context)
        {
            //context.ExceptionHandled = true;
            ////日志基本信息
            //var urlPath = context.HttpContext.Request.Path;
            //var method = context.HttpContext.Request.Method;
            //var body = HttpContextHelper.GetJsonRequestBody(context.HttpContext);
            //var parmas = context.HttpContext.Request.Query.Select(m => m.Key + "=" + m.Value).ToList();
            //var query = string.Join(",", parmas);
            ////日志StringBuilder
            //var sb = new StringBuilder();
            //sb.AppendLine($"Url请求地址：{urlPath}");
            //sb.AppendLine($"请求方式：{method}");
            //sb.AppendLine($"请求的Query：{query}");
            //sb.AppendLine($"请求Json入参：{body}");
            ////返回模型构建
            //var model = new ApiResult(ApiResultCode.Failed);
            //if (context.Exception is BaseApiException baseEx)
            //{
            //    model.Msg = baseEx.Message;
            //    model.Code = baseEx.ExceptionCode;
            //}
            //else
            //{
            //    model.Msg = _isDev ? context.Exception.Message : "服务器异常请联系管理员";
            //}

            //var returnMsg = model.ToJson();
            //sb.AppendLine($"返回结果：{returnMsg}");
            //AquariumLogManager.GetInstance().Error(sb.ToString(), context.Exception, tags: "异常拦截器日志");
            //// var result = new JsonResult(model, new JsonSerializerSettings { ReferenceLoopHandling = ReferenceLoopHandling.Ignore }) { StatusCode = 200 };
            //var result = new ContentResult { Content = returnMsg, StatusCode = 200, ContentType = "application/json" };
            //context.Result = result;
            return Task.CompletedTask;
        }
    }
}
