using AllPlay.Application.Abstractions;
using AllPlay.Application.DTO;
using AllPlay.Application.Map.Commands;
using AllPlay.Application.Map.Commands.Handlers;
using AllPlay.Application.Map.Queries;
using AllPlay.Application.Map.Queries.Handlers;
using Microsoft.Extensions.DependencyInjection;

namespace AllPlay.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<ICommandHandler<CreateMarkerCommand>, CreateMarkerCommandHandler>();
        services.AddScoped<IQueryHandler<GetMarkerQuery, MarkerDto>, GetMarkerQueryHandler>();
        services.AddScoped<IQueryHandler<BrowseMarkerQuery, IReadOnlyList<MarkerDto>>, BrowseMarkerQueryHandler>();
        
        return services;
    }
}