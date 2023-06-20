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
        private IEmailService _emailService;
        public MiddlewareFoo(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext,IEmailService service)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            _emailService = service;
            await _emailService.SendEmail("Invoked Method Foo", "Admin", "Invoke Started");
            Console.WriteLine("(Red) Before Foo");
            await _next(httpContext);
            Console.WriteLine("(Blue) After Foo");
            Console.ResetColor();
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseMiddlewareFoo(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<MiddlewareFoo>();
        }
    }
}
