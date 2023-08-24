using Application.Query.SendCheckInLate;
using Domain.Extension;
using FluentValidation.TestHelper;
using Xunit;

namespace Application.UnitTests.Validator;

public sealed class TestCommitSendCheckInLateValidator : BaseApplicationUnitTest
{
    private CommitSendCheckInLateValidator validator = null;
    public TestCommitSendCheckInLateValidator()
    {
        // Arrange
        validator = new CommitSendCheckInLateValidator();
    }

    [Theory]
    [InlineData("MN_INTERNET_ID")]
    [InlineData("MN_ORDER_NO")]
    [InlineData("MN_APPOINTMENT_DATE")]
    [InlineData("MN_SLOT")]
    [InlineData("MN_PACKAGE")]
    [InlineData("MN_PRODUCT_NAME")]
    [InlineData("MN_ORDER_TYPE")]
    [InlineData("MN_CUSTOMER_NAME")]
    [InlineData("MN_CUSTOMER_CONTACT_1")]
    [InlineData("MN_CUSTOMER_ADDRESS")]
    [InlineData("MN_CUSTOMER_LATITUDE")]
    [InlineData("MN_CUSTOMER_LONGITUDE")]
    [InlineData("MN_REGION")]
    [InlineData("MN_STAFF_CODE")]
    [InlineData("MN_STAFF_NAME")]
    [InlineData("MN_STAFF_PHONE")]
    [InlineData("MN_SUBCONTRACT_TEAM")]
    [InlineData("MN_CHECKIN_LATE_TIME")]
    [InlineData("MN_CHECKIN_LATE_REASON")]
    [InlineData("MN_REMARKS")]
    [InlineData("MN_CURRENT_LATITUDE")]
    [InlineData("MN_CURRENT_LONGITUDE")]
    [InlineData("MN_CREATE_DATE")]
    [InlineData("MN_CREATED_BY")]
    public void Should_Error_when_RequireProperty_is_NullOrEmpty(string propName)
    {
        // Arrange
        var req = GetTempSendCheckInLate();
        req.SetValueByName(propName, "");
        // Act
        var result = validator.TestValidate(req);
        // Assert
        result.ShouldHaveValidationErrorFor(propName);
    }

    [Fact]
    public void Should_Pass_when_RequireProperty_is_HaveValue()
    {
        // Arrange
        var req = GetTempSendCheckInLate();
        // Act
        var result = validator.TestValidate(req);
        // Assert
        result.ShouldNotHaveAnyValidationErrors();
    }
}


