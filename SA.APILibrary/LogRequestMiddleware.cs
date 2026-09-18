namespace SA.APILibrary
{
    public class LogRequestMiddleware
    {
        private readonly RequestDelegate _next;

        public LogRequestMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var logger = context.RequestServices.GetRequiredService<ILogger<Program>>();
            logger.LogInformation("Handling request: {Method} {Path}", context.Request.Method, context.Request.Path);
            await _next(context);
            logger.LogInformation("Finished handling request. Status: {StatusCode}", context.Response.StatusCode);
        } 
    }

    public static class LogRequestMiddlewareExtensions
    {
        public static IApplicationBuilder UseLogRequestMiddleware(this IApplicationBuilder builder) // aqui le estoy agregando un metodo de extension a la clase IApplicationBuilder
        {
            return builder.UseMiddleware<LogRequestMiddleware>();
        }
    }
} 
 