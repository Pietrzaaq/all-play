using AllPlay.Api;
using AllPlay.Application;
using AllPlay.Infrastructure;
using Microsoft.AspNetCore.Identity;

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
    
    builder.Services
        .AddApplication()
        .AddInfrastructure(builder.Configuration)
        .AddPresentation();
}

var app = builder.Build();
{
    app.MapIdentityApi<IdentityUser>();
    
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

