using Application.Common.Core;
using Application.Common.Interfaces;
using Application.IntegrationTests;
using Application.Query.NotifyAppointmentOrder;
using Application.Query.SendCheckInLate;
using Application.Util;
using Serilog;

namespace Application.IntegrationTests.Handler;

public sealed class TestCommitSendCheckInLateHandler: BaseIntergrationTest
{
    public TestCommitSendCheckInLateHandler(IntegrationTestWebAppFactory factory)
     : base(factory)
    {
    }

    [Fact]
    public async Task Commit_ShouldThrowValidateException_WhenFibrenetIdEmpty()
    {
        //Arrange
        var req = TempNotifyInstall;
        req.FIBRENET_ID = "";

        //Act
        async Task Action() => Sender.Send(req);

        //Assertq
        await Assert.ThrowsAsync<ValidationException>(Action);
    }

    [Fact]
    public async Task Commit_ShouldAddNewRecord_WhenRequestIsValid()
    {
        //Arrange
        var req = TempNotifyInstall;
        req.Header = new RequestHeader
        {
            TransactionId = GenUtil.GenTransactionId("IT"),
            AppSource = "UnitTest",
            AppDestination = "MiniEAI"
        };

        //Act
        Task Action() => Sender.Send(req);

        //Assertq
        var header = PrimaryDb.FbbTblEvSendChecklateHeaders.FirstOrDefault(x => x.TransactionId == req.TransactionId);
        Assert.NotNull(header);
    }
}