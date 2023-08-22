using Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Serilog;

namespace Application.UnitTests;

public class FixtureApplicationUnitTest : IDisposable
{
    private readonly IConfiguration _configuration;
    private readonly IServiceProvider _serviceProvider;
    public IConfiguration Configuration => _configuration;
    public IServiceProvider Provider => _serviceProvider;
    public FixtureApplicationUnitTest()
    {
        _configuration = GetConfiguration();
        _serviceProvider = GetProvider(_configuration);
    }

    private IConfiguration GetConfiguration()
    {
        var builder = new ConfigurationBuilder()
           .SetBasePath(Directory.GetCurrentDirectory())
           .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
           .AddEnvironmentVariables();
        return builder.Build();
    }

    private IServiceProvider GetProvider(IConfiguration configuration)
    {
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
    public void Dispose()
    {
    }
}
