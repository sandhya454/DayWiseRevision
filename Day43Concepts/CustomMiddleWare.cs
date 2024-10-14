using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Day43Concepts
{
    public class CustomMiddleWare : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("Hello from new file 1\n");
            await next(context);
            await context.Response.WriteAsync("Hello from new File 2");
        }
    }
}
