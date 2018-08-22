using System;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CYJ.Base.Service.Http.Filters
{
    public class BaseResultFilterAttribute : ResultFilterAttribute, IResultFilter
    {
        public override void OnResultExecuting(ResultExecutingContext context)
        {
        }

        public override void OnResultExecuted(ResultExecutedContext context)
        {
        }
    }
}
