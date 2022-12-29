using AllPlay.Application.Abstractions;
using AllPlay.Application.Interfaces.Services;
using AllPlay.Infrastructure.Commands;
using Microsoft.Extensions.DependencyInjection;
using AllPlay.Infrastructure.Persistence;
using AllPlay.Infrastructure.Queries;
using AllPlay.Infrastructure.Services;
using Microsoft.Extensions.Configuration;

namespace AllPlay.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services,
        IConfiguration configuration)
    {


        services.AddSingleton<IDispatcher, InMemoryDispatcher>();
        services.AddSingleton<IQueryDispatcher, InMemoryQueryDispatcher>();
        services.AddSingleton<ICommandDispatcher, InMemoryCommandDispatcher>();
        services.AddDatabase(configuration);
        services.AddScoped<IDateTimeProvider, DateTimeProvider>();
        return services;
    }
}