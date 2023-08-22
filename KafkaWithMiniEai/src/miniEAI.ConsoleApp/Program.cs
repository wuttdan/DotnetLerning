using Application;
using Infrastructure;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using miniEAI.ConsoleApp.AppTest;
using miniEAI.ConsoleApp.CoreTest;
using Serilog.Events;
using System.Reflection;

namespace miniEAI.ConsoleApp;

static class Program
{
    static async Task Main(string[] args)
    {
        try
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
                .Enrich.FromLogContext()
                .WriteTo.Console()
                .WriteTo.Debug()
                .CreateBootstrapLogger();

            var host = CreateHostBuilder(args).Build();
            var provider = host.Services;

            Log.Information("Application Running");

            ////await SimpleRun<TestPrintJson>(provider, args);
            ////await SimpleRun<TestJsonPath>(provider, args);
            await SimpleRun<Testpolymorphism>(provider, args);

            await host.RunAsync();
        }
        catch (Exception ex)
        {
            Log.Error(ex, "Error Program.Main");
        }

        Log.Information("Ended");

        var _wait = !args.Any(x => x.Contains("nowait"));
        if (_wait)
        {
            var key = Console.ReadKey();
            Log.Information("ReadKey: {0}", key.Key);
        }
    }

    private static async Task SimpleRun<TService>(IServiceProvider provider, params string[] args)
        where TService : ApplicationTestBase
    {
        var service = provider.GetRequiredService<TService>();
        await service.Run(args);
    }

    static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            .UseContentRoot(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location))
            .ConfigureHostConfiguration(builder =>
            {
                builder
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                    .AddEnvironmentVariables();
                if (args != null) builder.AddCommandLine(args);
            })
            .ConfigureServices((context, services) =>
            {
                services.AddSingleton(context.Configuration);
                //
                ////var fbbeaiConnectionString = Configuration.GetConnectionString("FbbeaiConnectionString");
                ////var fbbHvrConnectionString = Configuration.GetConnectionString("FbbhvrConnectionString");
                ////
                ////AppSetting = Configuration.GetSection("AppSettings").Get<ApplicationSetting>();
                ////AppSetting.AuthenDbConfig = Configuration.GetSection("AuthenDbConfig").Get<AuthenDbConfigModel>();
                ////AppSetting.Append(AppSetting.MINIEAI_NAME, fbbeaiConnectionString);
                ////AppSetting.Append(AppSetting.HVRDB_NAME, fbbHvrConnectionString);
                ////services.AddSingleton(AppSetting);

                services.AddHttpClient();

                services.ConfigureDomain(context.Configuration);
                services.ConfigureApplication(context.Configuration);
                services.ConfigureInfrastructure(context.Configuration);

                //Scrutor
                services.Scan(s => s.FromAssemblyOf<ApplicationTestBase>()
                         .AddClasses()
                         .AsSelf()
                         .WithSingletonLifetime());
            })
            .UseSerilog((ctx, cfg) => cfg.ReadFrom.Configuration(ctx.Configuration));
}