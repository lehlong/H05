using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace H05.API.Middleware
{
    public class StaticTokenAuthMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly string _staticToken;

        public StaticTokenAuthMiddleware(RequestDelegate next, IConfiguration configuration)
        {
            _next = next;
            _staticToken = configuration["JWT:Key"];
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var path = context.Request.Path.Value;

            if (path.StartsWith("/swagger") || path.StartsWith("/log") || path.StartsWith("/uploads"))
            {
                await _next(context);
                return;
            }

            var authHeader = context.Request.Headers["Authorization"].ToString();

            if (string.IsNullOrEmpty(authHeader) || !authHeader.StartsWith("Bearer "))
            {
                context.Response.StatusCode = StatusCodes.Status401Unauthorized;
                await context.Response.WriteAsync("Unauthorized: Không có token hoặc token không hợp lệ!.");
                return;
            }

            var incomingToken = authHeader.Substring("Bearer ".Length).Trim();

            if (_staticToken != incomingToken)
            {
                context.Response.StatusCode = StatusCodes.Status401Unauthorized;
                await context.Response.WriteAsync("Unauthorized: Token không hợp lệ!.");
                return;
            }

            await _next(context);
        }
    }
}
