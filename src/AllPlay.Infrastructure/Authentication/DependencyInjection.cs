using AllPlay.Infrastructure.Persistence;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AllPlay.Infrastructure.Authentication;

internal static class DependencyInjection
{
    public static IServiceCollection AddAuth(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddAuthorization();
        services.AddIdentityApiEndpoints<IdentityUser>()
            .AddEntityFrameworkStores<AllPlayDbContext>();
        
        return services;
    }
}