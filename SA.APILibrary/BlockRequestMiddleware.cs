namespace SA.APILibrary
{
    public class BlockRequestMiddleware
    {
        private readonly RequestDelegate next;

        public BlockRequestMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            if (context.Request.Path == "/bloqueado")
            {
                context.Response.StatusCode = 403; // Forbidden
                await context.Response.WriteAsync("Access to this resource is forbidden.");
            }
            else
            {
                await next(context);
            }
        } 
    }

    public static class BlockRequestMiddlewareExtensions
    {
        public static IApplicationBuilder UseBlockRequestMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<BlockRequestMiddleware>();
        }
    }
}
