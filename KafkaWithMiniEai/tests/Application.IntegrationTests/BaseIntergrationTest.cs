using Application.Common.Interfaces;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Application.IntegrationTests;

public abstract partial class BaseIntergrationTest : IClassFixture<IntegrationTestWebAppFactory>
{
    private readonly IServiceScope _scope;
    protected readonly ISender Sender;
    protected readonly IPrimaryDbContext PrimaryDb;
    public BaseIntergrationTest(IntegrationTestWebAppFactory factory)
    {
        _scope = factory.Services.CreateScope();
        Sender = _scope.ServiceProvider.GetRequiredService<ISender>();
        PrimaryDb = _scope.ServiceProvider.GetRequiredService<IPrimaryDbContext>();
    }
}