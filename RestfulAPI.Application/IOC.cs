using Microsoft.Extensions.DependencyInjection;
using RestfulAPI.Application.Services;

namespace RestfulAPI.Application;
public static class IOC
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<IdentityService, IdentityService>();

        return services;
    }
}
