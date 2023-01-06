using AllPlay.Application.Commands;
using AllPlay.Application.Commands.Handlers;
using AllPlay.Application.Common.Abstractions;
using AllPlay.Application.DTO;
using AllPlay.Application.Queries;
using AllPlay.Application.Queries.Handlers;
using Microsoft.Extensions.DependencyInjection;

namespace AllPlay.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<ICommandHandler<CreateSportEventCommand>, CreateSportEventCommandHandler>();
        services.AddScoped<ICommandHandler<CreateAreaCommand>, CreateAreaCommandHandler>();
        services.AddScoped<IQueryHandler<GetSportEventsQuery, SportEventDto>, GetSportEventQueryHandler>();
        services.AddScoped<IQueryHandler<BrowseSportEventsQuery, IReadOnlyList<SportEventDto>>, BrowseSportEventsQueryHandler>();
        services.AddScoped<IQueryHandler<GetAreaQuery, AreaDto>, GetAreaQueryHandler>();
        
        return services;
    }
}