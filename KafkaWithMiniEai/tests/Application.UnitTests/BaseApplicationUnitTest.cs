using Application.Common.Core;
using Application.Common.Interfaces;
using Application.Util;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Application.UnitTests;

public abstract partial class BaseApplicationUnitTest : IClassFixture<FixtureApplicationUnitTest>
{
    private readonly FixtureApplicationUnitTest _appFixture;
    private readonly IServiceScope _scope;

    protected readonly IMediator Mediator;
    protected readonly IPrimaryDbContext PrimaryDb;
    protected IServiceProvider Provider => _scope.ServiceProvider;
    public BaseApplicationUnitTest(FixtureApplicationUnitTest appFixture)
    {
        _appFixture = appFixture;
        _scope = _appFixture.Provider.CreateScope();
        Mediator = _scope.ServiceProvider.GetRequiredService<IMediator>();
        PrimaryDb = _scope.ServiceProvider.GetRequiredService<IPrimaryDbContext>();
    }

    protected T GetService<T>()
    {
        return Provider.GetRequiredService<T>();
    }

    protected RequestHeader GetCommonRequestHeader(string? transactionId = null, string? appSource = "IntegrationTest", string? appDestination = "MiniEai") => new()
    {
        TransactionId = transactionId ?? GenUtil.GenTransactionId(),
        AppSource = appSource,
        AppDestination = appDestination
    };
}