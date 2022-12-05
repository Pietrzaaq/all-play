using AllPlay.Application.Interfaces.Services;
using Microsoft.Extensions.DependencyInjection;
using AllPlay.Infrastructure.Persistence;
using AllPlay.Infrastructure.Services;
using Microsoft.Extensions.Configuration;

namespace AllPlay.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddScoped<IDateTimeProvider, DateTimeProvider>();
        
        services.AddDatabase(configuration);
        return services;
    }
}