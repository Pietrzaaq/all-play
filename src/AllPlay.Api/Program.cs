using AllPlay.Api;
using AllPlay.Application;
using AllPlay.Infrastructure;
using Microsoft.OpenApi.Models;

var allowOrigins = "AllowOrigins";

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddCors(options =>
    {
        options.AddPolicy(name: allowOrigins,
            policy  =>
            {
                policy.WithOrigins()
                    .AllowAnyHeader()
                    .AllowAnyMethod()
                    .AllowAnyOrigin();
            });
    });
    
    builder.Services.AddSwaggerGen(swagger =>
    {
        swagger.SwaggerDoc("v1", new OpenApiInfo
        {
            Title = builder.Configuration["Api:Name"],
            Version = builder.Configuration["Api:Version"]
        });
    });
    
    builder.Services
        .AddApplication()
        .AddInfrastructure(builder.Configuration)
        .AddPresentation();
}

var app = builder.Build();
{
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseHttpsRedirection();
    app.UseCors(allowOrigins);
    app.MapControllers();
    app.Run();
}

