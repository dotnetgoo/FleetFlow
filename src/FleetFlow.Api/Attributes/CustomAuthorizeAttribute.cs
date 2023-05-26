using FleetFlow.Shared.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Security.Claims;

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
            var result = controllerDescriptor?.ControllerName.ToLower() + "." + controllerDescriptor?.ActionName.ToLower();
            var role = context.HttpContext.User.Claims.FirstOrDefault(u => u.Type == ClaimTypes.Role).Value;

            var res = role;
        }

    }
}
