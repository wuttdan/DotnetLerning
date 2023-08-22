using Application.Common.Interfaces;
using Infrastructure.Persistences;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics;
using System.Security.Cryptography;
using Testcontainers.MsSql;
using Xunit;

namespace Application.IntegrationTests;

public class IntegrationTestWebAppFactory : WebApplicationFactory<Program>, IAsyncLifetime
{
    private readonly MsSqlContainer msSqlContainer = new MsSqlBuilder().Build();

    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
        builder.ConfigureTestServices(services =>
        {
            var descriptor = services
            .SingleOrDefault(x => x.ServiceType == typeof(DbContextOptions<MiniEaiDbContext>));
            if (descriptor is not null)
            {
                services.Remove(descriptor);
            }
            var primaryDbConnectionString = msSqlContainer.GetConnectionString();
            Debug.WriteLine($"primaryDbConnectionString: {primaryDbConnectionString}");
            services.AddDbContext<MiniEaiDbContext>(options =>
            {
                options.UseSqlServer(primaryDbConnectionString);
            });
        });
    }
    public async Task InitializeAsync()
    {
        var primaryDb = Services.GetRequiredService<IPrimaryDbContext>();
        await primaryDb.Db.MigrateAsync();
        await msSqlContainer.StartAsync();
    }

    async Task IAsyncLifetime.DisposeAsync()
    {
        await msSqlContainer.StopAsync();
    }
}