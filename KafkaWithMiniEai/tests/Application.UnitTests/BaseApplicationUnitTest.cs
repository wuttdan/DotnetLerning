using Application.Common.Core;
using Application.Common.Interfaces;
using Application.Common.Models.Authorization;
using Application.Util;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Application.UnitTests;

public abstract partial class BaseApplicationUnitTest
{
    protected RequestHeader GetCommonRequestHeader(string? transactionId = null, string? appSource = "IntegrationTest", string? appDestination = "MiniEai") => new()
    {
        TransactionId = transactionId ?? GenUtil.GenTransactionId(),
        AppSource = appSource,
        AppDestination = appDestination
    };

    protected AuthorizationRequestHeader GetAuthorizationHeader(string? transactionId = null, string? appSource = "IntegrationTest", string? appDestination = "MiniEai") => new()
    {
        Version = "",
        ReqId = transactionId ?? GenUtil.GenTransactionId(),
        AppName = "",
        ClientId = "",
    };
}