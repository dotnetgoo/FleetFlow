using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FleetFlow.Service.Exceptions;

namespace FleetFlow.Api.Middlewares
{
    public class ExceptionHandlerMiddleware
    {
        private readonly RequestDelegate next;

        public ExceptionHandlerMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                // try to do it
            }
            catch(FleetFlowException exception)
            {
                // handle request
            }
            catch(Exception exception)
            {
                // handle request
            }
        }
    }
}