namespace CleanArchitecture.WebApi.Middleware;

public static class MiddlewareExtansion
{
    public static IApplicationBuilder UseMiddlewareExtansions(this IApplicationBuilder app)

    {
        app.UseMiddleware<ExceptionMiddleware>();
        return app;
    }
}
