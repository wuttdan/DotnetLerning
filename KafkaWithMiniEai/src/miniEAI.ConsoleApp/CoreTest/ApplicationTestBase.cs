using Application.Common.Core;
using Application.Util;

namespace miniEAI.ConsoleApp.CoreTest;

public abstract partial class ApplicationTestBase : IApplicationTest
{
    protected readonly ILogger _logger;

    protected ApplicationTestBase(ILogger logger)
    {
        _logger = logger;
    }

    public virtual Task Run(params string[] args)
    {
        throw new NotImplementedException();
    }

    protected RequestHeader GetCommonRequestHeader(string? transactionId = null, string? appSource = "ConsoleApp", string? appDestination = "MiniEai") => new ()
    {
        TransactionId = transactionId ?? GenUtil.GenTransactionId(),
        AppSource = appSource,
        AppDestination = appDestination
    };





    ////protected RequestHeader GetRequestHeader(string? appSource = null, string? appDestination = null)
    ////{
    ////    return new ()
    ////    {
    ////        TransactionId = GenUtil.GenTransactionId(),
    ////        AppSource = appSource ?? "ConsoleApp",
    ////        AppDestination = appDestination ?? "MiniEai"
    ////    };
    ////}

}
