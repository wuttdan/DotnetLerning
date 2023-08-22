using Application.Common.Core;
using Application.Util;

namespace Application.IntegrationTests.Handler;

////https://www.youtube.com/watch?v=tj5ZCtvgXKY
////The Best Way To Use Docker For Integration Testing In .NET
public class TestCommitNotifyAppointmentOrderHandler : BaseIntergrationTest
{
    public TestCommitNotifyAppointmentOrderHandler(IntegrationTestWebAppFactory factory)
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
        var header = PrimaryDb.FbbTblEvNotifyAppointmentHeaders.FirstOrDefault(x => x.TransactionId == req.TransactionId);
        Assert.NotNull(header);
    }
}