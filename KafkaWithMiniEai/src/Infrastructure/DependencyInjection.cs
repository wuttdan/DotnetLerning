using Application.Common.Interfaces;
using Application.Extension;
using Infrastructure.Persistences;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection ConfigureInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        var primaryDbConnectionString = configuration.GetConnectionString("PrimaryDbConnectionString");
        var secondaryDbConnectionString = configuration.GetConnectionString("SecondaryDbConnectionString");
        services.AddDbContextPool<MiniEaiDbContext>(options =>
               options.UseSqlServer(
                    primaryDbConnectionString!,
                    b =>
                    {
                        b.MigrationsAssembly("miniEAI.WebApi");
                        b.CommandTimeout((int)TimeSpan.FromMinutes(20).TotalSeconds);
                        b.EnableRetryOnFailure(5, TimeSpan.FromMinutes(5.0), null);
                    }));
        services.AddDbContextPool<HvrDbContext>(options =>
           options.UseNpgsql(
                secondaryDbConnectionString!,
                b =>
                {
                    b.CommandTimeout((int)TimeSpan.FromMinutes(20).TotalSeconds);
                    b.EnableRetryOnFailure(5, TimeSpan.FromMinutes(5.0), null);
                }));
        services.AddScoped<IPrimaryDbContext>(provider => provider.GetRequiredService<MiniEaiDbContext>());
        services.AddScoped<ISecondaryDbContext>(provider => provider.GetRequiredService<HvrDbContext>());

        services.AddScoped<ICacheLovRepository, CacheLovRepository>();
        services.AddScoped<ICacheValidateRepository, CacheValidateRepository>();

        services.AddHttpClient();
        services.AddHttpClient(IHttpClientFactory_Extension.BypassClientName)
            .ConfigurePrimaryHttpMessageHandler(() =>
            {
                return new HttpClientHandler()
                {
                    ClientCertificateOptions = ClientCertificateOption.Manual,
                    ServerCertificateCustomValidationCallback = (httpRequestMessage, cert, cetChain, policyErrors) => true
                };
            });

        return services;
    }
}