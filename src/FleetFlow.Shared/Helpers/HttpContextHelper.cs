using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetFlow.Shared.Helpers
{
    public class HttpContextHelper
    {
        public static IHttpContextAccessor Accessor { get; set; }
        public static HttpContext HttpContext => Accessor?.HttpContext;
        public static long? UserId => long.Parse(HttpContext?.User?.FindFirst("Id")?.Value);
        public static string UserRole => HttpContext?.User.FindFirst("role")?.Value;
    }
}
