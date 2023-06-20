using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using MiddleWareMVCApp.Services;
using System.Threading.Tasks;

namespace MiddleWareMVCApp
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class MiddlewareFoo
    {
        private readonly RequestDelegate _next;
        private  IEmailService _emailService;

        public MiddlewareFoo(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext,IEmailService service)
        {
            _emailService=service;
            await _emailService.SendEmail("invoke method foo", "admin", "invoke started");
            Console.WriteLine("(RED)Before Foo");
            await _next(httpContext);
            Console.WriteLine("(BLUE)After Foo");

        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class MiddlewareFooExtensions
    {
        public static IApplicationBuilder UseMiddlewareFoo(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<MiddlewareFoo>();
        }
    }
}
