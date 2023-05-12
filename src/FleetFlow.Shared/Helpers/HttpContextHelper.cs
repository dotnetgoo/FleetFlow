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
        public static IHeaderDictionary ResponseHeaders => HttpContext?.Response?.Headers;
        public static long? UserId => long.TryParse(HttpContext?.User?.FindFirst("Id")?.Value, out _tempUserId) ? _tempUserId : null;
        public static string UserRole => HttpContext?.User?.FindFirst("role")?.Value;

        private static long _tempUserId;
    }
}
