using AllPlay.Application.Abstractions.Common;
using AllPlay.Application.Abstractions.Geolocation;
using Microsoft.Extensions.DependencyInjection;
using AllPlay.Infrastructure.Persistence;
using AllPlay.Infrastructure.Services.Common;
using AllPlay.Infrastructure.Services.Geolocation;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Serialization;

namespace AllPlay.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services,
        IConfiguration configuration)
    {
        NetTopologySuite.NtsGeometryServices.Instance = new NetTopologySuite.NtsGeometryServices(
            NetTopologySuite.Geometries.Implementation.CoordinateArraySequenceFactory.Instance,
            new NetTopologySuite.Geometries.PrecisionModel(1000d),
            4326, 
            NetTopologySuite.Geometries.GeometryOverlay.NG,
            new NetTopologySuite.Geometries.CoordinateEqualityComparer());
        
        services.AddDatabase(configuration);
        services.AddScoped<IDateTimeProvider, DateTimeProvider>();
        services.AddSingleton<IGeolocationService, GeolocationService>();

        services.AddControllers()
            .AddNewtonsoftJson(options =>
                options.SerializerSettings.ContractResolver = new DefaultContractResolver());
        
        return services;
    }
}