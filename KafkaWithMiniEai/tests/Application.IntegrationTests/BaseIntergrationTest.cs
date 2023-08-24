using Application.Common.Core;
using Application.Common.Interfaces;
using Application.Util;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Application.IntegrationTests;

public abstract partial class BaseIntergrationTest : IClassFixture<IntegrationTestWebAppFactory>
{
    private readonly IServiceScope _scope;
    protected readonly IMediator Mediator;
    protected readonly IPrimaryDbContext PrimaryDb;
    public BaseIntergrationTest(IntegrationTestWebAppFactory factory)
    {
        _scope = factory.Services.CreateScope();
        Mediator = _scope.ServiceProvider.GetRequiredService<IMediator>();
        PrimaryDb = _scope.ServiceProvider.GetRequiredService<IPrimaryDbContext>();
    }

    protected RequestHeader GetCommonRequestHeader(string? transactionId = null, string? appSource = "IntegrationTest", string? appDestination = "MiniEai") => new()
    {
        TransactionId = transactionId ?? GenUtil.GenTransactionId(),
        AppSource = appSource,
        AppDestination = appDestination
    };

    protected void AssertErrorCodeDesc() 
    {

    }
}