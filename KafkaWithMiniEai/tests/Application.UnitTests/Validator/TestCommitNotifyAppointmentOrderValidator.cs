using Application.Common.Models.NotifyAppointmentOrder;
using Application.Query;
using Application.Query.NotifyAppointmentOrder;

namespace Application.UnitTests.Validator;

public sealed class TestCommitNotifyAppointmentOrderValidator : BaseApplicationUnitTest
{
    private CommitNotifyAppointmentOrderValidator validator;
    public TestCommitNotifyAppointmentOrderValidator(FixtureApplicationUnitTest appFixture)
        : base(appFixture)
    {
        // Arrange
        validator = new CommitNotifyAppointmentOrderValidator();
    }

    [Fact]
    public void Should_Error_when_FibrenetId_is_NullOrEmpty()
    {
        // Arrange
        var req = new CommitNotifyAppointmentOrderRequestModel
        {
            FIBRENET_ID = "",
            TYPE = "",
            TYPE_OPER_DATE = "",
            MSG_SEQ_ID = "",
            MA_ORDER = null,
            INSTALL_ORDER = null
        };

        // Act
        var result = validator.TestValidate(req);

        // Assert
        result.ShouldHaveValidationErrorFor(req => req.FIBRENET_ID);
    }

    [Fact]
    public void Should_Error_when_Type_is_NullOrEmpty()
    {

        // Arrange
        var req = new CommitNotifyAppointmentOrderRequestModel
        {
            FIBRENET_ID = "0000000000",
            TYPE = ""
        };

        // Act
        var result = validator.TestValidate(req);

        // Assert
        result.ShouldHaveValidationErrorFor(req => req.TYPE);
    }

    [Fact]
    public void Should_Error_when_TypeOperDate_is_NullOrEmpty()
    {

        // Arrange
        var req = new CommitNotifyAppointmentOrderRequestModel
        {
            FIBRENET_ID = "0000000000",
            TYPE = "TYPE",
            TYPE_OPER_DATE = ""
        };

        // Act
        var result = validator.TestValidate(req);

        // Assert
        result.ShouldHaveValidationErrorFor(req => req.TYPE_OPER_DATE);
    }

    [Fact]
    public void Should_Error_when_MsgSeqId_is_NullOrEmpty()
    {

        // Arrange
        var req = new CommitNotifyAppointmentOrderRequestModel
        {
            FIBRENET_ID = "0000000000",
            TYPE = "TYPE",
            TYPE_OPER_DATE = "YYYY-MM-DD HH:mm:ss",
            MSG_SEQ_ID = ""
        };

        // Act
        var result = validator.TestValidate(req);

        // Assert
        result.ShouldHaveValidationErrorFor(req => req.MSG_SEQ_ID);
    }

    [Fact]
    public void Should_Error_when_MaOrderInstallOrder_is_NullOrEmpty()
    {

        // Arrange
        var req = new CommitNotifyAppointmentOrderRequestModel
        {
            FIBRENET_ID = "0000000000",
            TYPE = "TYPE",
            TYPE_OPER_DATE = "YYYY-MM-DD HH:mm:ss",
            MSG_SEQ_ID = "00",
            MA_ORDER = null,
            INSTALL_ORDER = null
        };

        // Act
        var result = validator.TestValidate(req);

        // Assert
        result.ShouldHaveAnyValidationError();
        Assert.Equal(false, result?.IsValid);
        Assert.Equal("'INSTALL_ORDER' and 'MA_ORDER' should not be dual null or empty.", result?.Errors.Single().ErrorMessage);
        Assert.Equal("40007", result?.Errors.Single().ErrorCode);
    }

    [Fact]
    public void Should_Pass_when_MaOrder_is_New()
    {

        // Arrange
        var req = new CommitNotifyAppointmentOrderRequestModel
        {
            FIBRENET_ID = "0000000000",
            TYPE = "TYPE",
            TYPE_OPER_DATE = "YYYY-MM-DD HH:mm:ss",
            MSG_SEQ_ID = "00",
            MA_ORDER = new NotifyAppointmentOrderMA()
        };

        // Act
        var result = validator.TestValidate(req);

        // Assert
        Assert.Equal(true, result?.IsValid);
    }

    [Fact]
    public void Should_Pass_when_InstallOrder_is_New()
    {

        // Arrange
        var req = new CommitNotifyAppointmentOrderRequestModel
        {
            FIBRENET_ID = "0000000000",
            TYPE = "TYPE",
            TYPE_OPER_DATE = "YYYY-MM-DD HH:mm:ss",
            MSG_SEQ_ID = "00",
            INSTALL_ORDER = new NotifyAppointmentOrderInstall()
        };

        // Act
        var result = validator.TestValidate(req);

        // Assert
        Assert.Equal(true, result?.IsValid);
    }
}


