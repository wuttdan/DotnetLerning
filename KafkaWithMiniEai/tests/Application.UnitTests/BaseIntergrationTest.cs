using Application.Common.Interfaces;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Application.UnitTests;

public abstract partial class BaseApplicationUnitTest : IClassFixture<FixtureApplicationUnitTest>
{
    private readonly FixtureApplicationUnitTest _appFixture;
    private readonly IServiceScope _scope;

    protected readonly ISender Sender;
    protected readonly IPrimaryDbContext PrimaryDb;
    protected IServiceProvider Provider => _scope.ServiceProvider;
    public BaseApplicationUnitTest(FixtureApplicationUnitTest appFixture)
    {
        _appFixture = appFixture;
        _scope = _appFixture.Provider.CreateScope();
        Sender = _scope.ServiceProvider.GetRequiredService<ISender>();
        PrimaryDb = _scope.ServiceProvider.GetRequiredService<IPrimaryDbContext>();
    }
}