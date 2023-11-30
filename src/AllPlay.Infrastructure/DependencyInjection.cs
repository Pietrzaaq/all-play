using AllPlay.Application.Common.Abstractions;
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
        services.AddDatabase(configuration);
        services.AddScoped<IDateTimeProvider, DateTimeProvider>();
        return services;
    }
}