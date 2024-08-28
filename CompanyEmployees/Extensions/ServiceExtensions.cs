namespace CompanyEmployees.Extensions;

public static class ServiceExtensions
{
    public static void ConfigureCors(this IServiceCollection services) =>
        services.AddCors(options =>
        {
            options.AddPolicy("CorsPolicy", builder =>
            builder.WithOrigins("https://localhost")
            .WithMethods("GET", "POST")
            .WithHeaders("accept", "content-type"));
        });
}
