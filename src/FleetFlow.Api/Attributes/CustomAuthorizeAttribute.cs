using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;

namespace FleetFlow.Api.Attributes;

public class CustomAuthorizeAttribute : TypeFilterAttribute
{
    public CustomAuthorizeAttribute() : base(typeof(CustomAuthorizationFilter))
    {
    }

    private class CustomAuthorizationFilter : IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var controllerDescriptor = context.ActionDescriptor as ControllerActionDescriptor;
            var controllerName = controllerDescriptor?.ControllerName;

            string token = context.HttpContext.Request.Headers["Authorization"];
            var tokeen = token;
        }
    }
}
