using AllPlay.Application.Interfaces.Repositories;
using AllPlay.Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AllPlay.Infrastructure.Persistence;

internal static class DependencyInjection
{

    public static IServiceCollection AddDatabase(this IServiceCollection services,
        IConfiguration configuration)
    {
        var connectionString = configuration[$"Database:ConnectionString"];
        services.AddDbContext<AllPlayDbContext>(x => x.UseSqlServer(connectionString));
        services.AddTransient<IMarkerRepository, MarkerRepository>();
        services.AddTransient<IAreaRepository, AreaRepository>();
        services.AddHostedService<DatabaseInitializer>();
        
        return services;
    }
}