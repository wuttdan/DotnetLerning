using Microsoft.Extensions.DependencyInjection;
using Domain;
using Infrastructure;
using Microsoft.Extensions.Configuration;
using Serilog.Events;
using Serilog;

namespace Application.UnitTests;

public static class ProviderHelper
{
    private static IConfiguration GetConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .AddEnvironmentVariables();
        return builder.Build();
    }

    private static IServiceProvider GetProvider()
    {
        var configuration = GetConfiguration();
        var services = new ServiceCollection();

        Log.Logger = new LoggerConfiguration()
            .ReadFrom.Configuration(configuration)
            .CreateLogger();

        services.AddSingleton(Log.Logger);

        services.ConfigureDomain(configuration);
        services.ConfigureApplication(configuration);
        services.ConfigureInfrastructure(configuration);

        return services.BuildServiceProvider();
    }

    public static T GetRequireService<T>()
    {
        var provider = GetProvider();
        return provider.GetRequiredService<T>();
    }
}