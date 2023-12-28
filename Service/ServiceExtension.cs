using Microsoft.Extensions.DependencyInjection;
using CrudApps.Service; 

public static class ServiceExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<BookService>();
        

        return services;
    }
}
