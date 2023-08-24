using Application.Common.Core;
using Application.Common.Models.NotifyAppointmentOrder;
using Application.Query;
using Application.Query.NotifyAppointmentOrder;
using Domain.Extension;

namespace Application.UnitTests.Validator;

public sealed class TestCommitNotifyAppointmentOrderValidator : BaseApplicationUnitTest
{
    private CommitNotifyAppointmentOrderValidator validator;
    public TestCommitNotifyAppointmentOrderValidator()
    {
        // Arrange
        validator = new CommitNotifyAppointmentOrderValidator();
    }

    [Theory]
    [InlineData("FIBRENET_ID")]
    [InlineData("TYPE")]
    [InlineData("TYPE_OPER_DATE")]
    [InlineData("MSG_SEQ_ID")]
    public void Should_Error_when_RequireProperty_is_NullOrEmpty(string propName)
    {
        // Arrange
        var req = GetTempNotifyInstall();
        req.SetValueByName(propName, "");
        // Act
        var result = validator.TestValidate(req);
        // Assert
        result.ShouldHaveValidationErrorFor(propName);
    }

    
    [Fact]
    public void Should_Error_when_MaOrderInstallOrder_is_NullOrEmpty()
    {

        // Arrange
        var req = GetTempNotifyInstall();
        req.Header.ContentType = AppConstant.HeaderContentType.APPJ_UTF8;
        req.SetValueByName("INSTALL_ORDER", null!);
        req.SetValueByName("MA_ORDER", null!);

        // Act
        var result = validator.TestValidate(req);

        // Assert
        result.ShouldHaveAnyValidationError();
        Assert.Equal(false, result?.IsValid);
        var error = result?.Errors.FirstOrDefault();
        Assert.Equal("'INSTALL_ORDER' and 'MA_ORDER' should not be dual null or empty.", error.ErrorMessage);
        Assert.Equal("40007", error.ErrorCode);
    }
}


