using Application;
using Application.Common.Core;
using Application.Middleware;
using Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json.Serialization;

try
{
    Log.Logger = new LoggerConfiguration()
            .WriteTo.Console()
            .WriteTo.Debug()
            .MinimumLevel.Debug()
            .CreateBootstrapLogger();

    Log.Information("Starting application");

    var builder = WebApplication.CreateBuilder(args);

    builder.Host.UseSerilog((ctx, cfg) => cfg.ReadFrom.Configuration(ctx.Configuration));

    // Add services to the container.
    builder.Services
        .Configure<KestrelServerOptions>(options =>
        {
            options.AllowSynchronousIO = true;
        })
        .Configure<IISServerOptions>(options =>
        {
            options.AllowSynchronousIO = true;
        })
        .Configure<HostOptions>(options =>
        {
            options.ShutdownTimeout = TimeSpan.FromSeconds(20);
            options.BackgroundServiceExceptionBehavior = BackgroundServiceExceptionBehavior.Ignore;
        })
        .Configure<ApiBehaviorOptions>(options =>
        {
            options.SuppressInferBindingSourcesForParameters = true;
            options.SuppressModelStateInvalidFilter = true;
        });
    builder.Services.AddControllers()
        .AddJsonOptions(options =>
        {
            options.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
            options.JsonSerializerOptions.PropertyNamingPolicy = null;
            options.JsonSerializerOptions.Converters.Add(new DateOnlyJsonConverter());
            options.JsonSerializerOptions.Converters.Add(new JsonDateTimeConverter());
        })
        .AddNewtonsoftJson(options =>
        {
            options.SerializerSettings.ContractResolver = new DefaultContractResolver();
        });

    builder.Services.AddLazyCache();
    builder.Services.AddHttpContextAccessor();
    builder.Services.AddLogging();
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();
    builder.Services.ConfigureInfrastructure(builder.Configuration);
    builder.Services.ConfigureApplication(builder.Configuration);

    var app = builder.Build();

    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseHttpsRedirection();

    app.UseAuthorization();

    app.UseMiddleware<RequestLoggingMiddleware>();

    app.MapControllers();

    app.Run();

}
catch (Exception ex)
{
    Log.Fatal(ex, "Application Starting up failed");
}
finally
{
    Log.CloseAndFlush();
}
