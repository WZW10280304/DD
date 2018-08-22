using System;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CYJ.Base.Service.Http.Filters
{
    public class BaseResourceFilterAttribute : Attribute, IResourceFilter
    {
        public void OnResourceExecuting(ResourceExecutingContext context)
        {
        }

        public void OnResourceExecuted(ResourceExecutedContext context)
        {
        }
    }
}
