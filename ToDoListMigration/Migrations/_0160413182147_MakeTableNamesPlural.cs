using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace ToDoListWithMigrations.Migrations
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class _0160413182147_MakeTableNamesPlural
    {
        private readonly RequestDelegate _next;

        public _0160413182147_MakeTableNamesPlural(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext)
        {

            return _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class _0160413182147_MakeTableNamesPluralExtensions
    {
        public static IApplicationBuilder UseMiddlewareClassTemplate(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<_0160413182147_MakeTableNamesPlural>();
        }
    }
}
