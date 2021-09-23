using System;
using System.Net;
using CryptoAnalytics.Entities;
using CryptoAnalytics.Entities.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;

namespace CryptoAnalytics.Api.Extensions
{
    public static class ExtensionHandler
    {
        public static void ConfigureExceptionHandler(this IApplicationBuilder app)
        {
            app.UseExceptionHandler(appError =>
            {
                appError.Run(async context =>
                {
                    context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    context.Response.ContentType = "application/json";
                    var contextFeature = context.Features.Get<IExceptionHandlerFeature>();

                    if (contextFeature != null)
                    {
                        var response = new Response<string>();
                        response.Success = false;
                        response.Data = "";
                        response.Errors.Add(contextFeature.Error.Message);
                        await context.Response.WriteAsJsonAsync(response);
                    }
                });
            });
        }
    }
}