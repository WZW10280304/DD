using System;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CYJ.Base.Service.Http.Filters
{
    public class BaseAuthFilterAttribute : Attribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            
        }
    }
}
