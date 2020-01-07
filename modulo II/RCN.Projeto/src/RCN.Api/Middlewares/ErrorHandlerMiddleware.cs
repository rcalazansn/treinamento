using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace RCN.Api.Middlewares
{
    public class ErrorHandlerMiddleware : IMiddleware
    {
        private readonly ILoggerFactory loggerFactory;

        public ErrorHandlerMiddleware(ILoggerFactory loggerFactory)
        {
            this.loggerFactory = loggerFactory;
        }

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next(context);
            }
            catch (Exception exception)
            {
                await HandleExceptionAsync(context, exception, loggerFactory);
            }
        }

        private static async Task HandleExceptionAsync(HttpContext context, Exception exception, ILoggerFactory loggerFactory)
        {

            var logger = loggerFactory.CreateLogger("Error");

            var exceptionObject = new ExceptionResponse(exception);
            var exceptionSerialized = JsonConvert.SerializeObject(exceptionObject);


            if (!context.Response.HasStarted)
            {
                context.Response.ContentType = "application/json";
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

                await context.Response.WriteAsync(exceptionSerialized);
            }
        }
    }
}
