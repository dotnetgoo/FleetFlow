using FleetFlow.Api.Models;
using FleetFlow.Service.Exceptions;
using FleetFlow.Service.Interfaces.Authorizations;
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

    public class CustomAuthorizationFilter : IAuthorizationFilter
    {
        private readonly IRolePermissionService rolePermissionService;

        public CustomAuthorizationFilter(IRolePermissionService rolePermissionService)
        {
            this.rolePermissionService = rolePermissionService;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {

            var controllerDescriptor = context.ActionDescriptor as ControllerActionDescriptor;
            var result = controllerDescriptor?.ControllerName.ToLower() + "." + controllerDescriptor?.ActionName.ToLower();
            var role = context.HttpContext?.User?.Claims?.FirstOrDefault(u => u.Type == ClaimTypes.Role)?.Value ?? string.Empty;
            var res = this.rolePermissionService.CheckPermission(role, result).GetAwaiter().GetResult();

            if (!res)
            {
                var exception = new FleetFlowException(403, "You do not have permission for this method");
                context.Result = new ObjectResult(new Response
                {
                    Code = exception.Code,
                    Message = exception.Message
                })
                {
                    StatusCode = exception.Code
                };
            }
        }

    }

}
