using Application.Common.Interfaces;
using Infrastructure.Persistences;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog.Core;
using System.Diagnostics;

namespace Application.IntegrationTests;

public class IntegrationTestWebAppFactory : WebApplicationFactory<Program>
{
    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
        builder.UseEnvironment("Development");

        builder.ConfigureTestServices(services =>
        {
            var descriptor = services
            .SingleOrDefault(x => x.ServiceType == typeof(DbContextOptions<MiniEaiDbContext>));
            if (descriptor is not null)
            {
                services.Remove(descriptor);
            }
            var primaryDbConnectionString = "Filename=IntegrationTests.db";
            Debug.WriteLine($"primaryDbConnectionString: {primaryDbConnectionString}");
            services.AddDbContext<MiniEaiDbContext>(options =>
            {
                ////options.UseSqlite(primaryDbConnectionString);
                options.UseInMemoryDatabase("InMemoryDbForTesting");
                options.ConfigureWarnings(x => x.Ignore(InMemoryEventId.TransactionIgnoredWarning));
            });
            // Build the service provider.
            var sp = services.BuildServiceProvider();
            using var scope = sp.CreateScope();
            var logger = scope.ServiceProvider.GetRequiredService<ILogger>();
            var primaryDb = scope.ServiceProvider.GetRequiredService<MiniEaiDbContext>();
            try
            {
                primaryDb.Database.EnsureCreated();
                primaryDb.Seeding();
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "An error occurred seeding the " +
                    "database with test messages. Error: {Message}", ex.Message);
            }
            
        });
    }
}