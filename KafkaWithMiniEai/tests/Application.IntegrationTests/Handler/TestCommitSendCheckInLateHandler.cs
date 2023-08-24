using Application.Common.Core;
using Application.Util;

namespace Application.IntegrationTests.Handler;

public sealed class TestCommitSendCheckInLateHandler : BaseIntergrationTest
{
    public TestCommitSendCheckInLateHandler(IntegrationTestWebAppFactory factory)
     : base(factory)
    {
    }

    [Fact]
    public async Task Commit_ShouldThrowValidateException_WhenFibrenetIdEmpty()
    {
        //Arrange
        var req = GetTempSendCheckInLate();
        req.MN_INTERNET_ID = "";

        //Act
        var res = await Mediator.Send(req);

        //Assert
        Assert.Equal(req.TransactionId, res.TRANSACTION_ID);
        Assert.Equal("50101", res.RESULT_CODE);
        Assert.Equal("'FIBRENET_ID' parameter(s) should not be null or empty.", res.RESULT_DESC);
    }

    [Fact]
    public async Task Commit_ShouldAddNewRecord_WhenRequestIsValid()
    {
        //Arrange
        var req = GetTempSendCheckInLate();

        //Act
        var res = await Mediator.Send(req);

        //Assert
        Assert.Equal(req.TransactionId, res.TRANSACTION_ID);
        Assert.Equal("20000", res.RESULT_CODE);
        Assert.Equal("Success", res.RESULT_DESC);
    }
}