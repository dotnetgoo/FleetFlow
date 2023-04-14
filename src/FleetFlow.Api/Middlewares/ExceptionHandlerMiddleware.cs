using FleetFlow.Api.Models;
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
                await next(context);
            }
            catch(FleetFlowException exception)
            {
                context.Response.StatusCode = exception.Code;
                await context.Response.WriteAsJsonAsync(new Response
                {
                    Code = exception.Code,
                    Error = exception.Message
                });
            }
            catch(Exception exception)
            {
                context.Response.StatusCode = 500;
                await context.Response.WriteAsJsonAsync(new Response
                {
                   Code = 500,
                   Error = exception.Message 
                });
            }
        }
    }
}