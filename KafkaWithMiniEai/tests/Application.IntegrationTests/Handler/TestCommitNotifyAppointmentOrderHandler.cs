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
        var req = GetTempNotifyInstall();
        req.FIBRENET_ID = "";

        //Act
        var res = await Mediator.Send(req);

        //Assert
        Assert.Equal(req.TransactionId, res.TRANSACTION_ID);
        Assert.Equal("40003", res.RESULT_CODE);
        Assert.Equal("'FIBRENET_ID' parameter(s) should not be null or empty.", res.RESULT_DESC);
    }

    [Fact]
    public async Task Commit_ShouldAddNewRecord_WhenRequestIsValid()
    {
        //Arrange
        var req = GetTempNotifyInstall();

        //Act
        var res = await Mediator.Send(req);

        //Assertq
        Assert.Equal(req.TransactionId, res.TRANSACTION_ID);
        Assert.Equal("20000", res.RESULT_CODE);
        Assert.Equal("Success", res.RESULT_DESC, true);
    }
}