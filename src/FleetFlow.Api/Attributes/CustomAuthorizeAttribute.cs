using FleetFlow.Service.Exceptions;
using FleetFlow.Service.Interfaces.Authorizations;
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

    public class CustomAuthorizationFilter : IAuthorizationFilter
    {
        private readonly IRolePermissionService rolePermissionService;

        public CustomAuthorizationFilter(IRolePermissionService rolePermissionService)
        {
            this.rolePermissionService = rolePermissionService;
        }

        public async void OnAuthorization(AuthorizationFilterContext context)
        {
            try
            {
                var controllerDescriptor = context.ActionDescriptor as ControllerActionDescriptor;
                var result = controllerDescriptor?.ControllerName.ToLower() + "." + controllerDescriptor?.ActionName.ToLower();
                var role = context.HttpContext.User.Claims.FirstOrDefault(u => u.Type == ClaimTypes.Role).Value;
                var res = await this.rolePermissionService.CheckPermission(role, result);
                if (!res)
                    throw new FleetFlowException(403, "You do not have permission for this method");
            }
            catch (Exception ex)
            {
                throw new FleetFlowException(400, ex.Message);
            }
        }

    }
}
