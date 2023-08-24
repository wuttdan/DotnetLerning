using Application.Query.SendCheckInLate;
using Domain.Extension;
using Xunit;

namespace Application.UnitTests.Validator;

public sealed class TestCommitSendCheckInLateValidator : BaseApplicationUnitTest
{
    private CommitSendCheckInLateValidator validator;
    public TestCommitSendCheckInLateValidator(FixtureApplicationUnitTest appFixture)
        : base(appFixture)
    {
        // Arrange
        validator = GetService<CommitSendCheckInLateValidator>();
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

    ////[Fact]
    ////public void Should_Error_when_OrderNo_is_NullOrEmpty()
    ////{
    ////    // Arrange
    ////    var req = GetTempSendCheckInLate();
    ////    req.MN_ORDER_NO = "";
    ////    // Act
    ////    var result = validator.TestValidate(req);
    ////    // Assert
    ////    result.ShouldHaveValidationErrorFor(req => req.MN_ORDER_NO);
    ////}
    ////
    ////[Fact]
    ////public void Should_Error_when_AppointmentDate_is_NullOrEmpty()
    ////{
    ////    // Arrange
    ////    var req = GetTempSendCheckInLate();
    ////    req.MN_APPOINTMENT_DATE = "";
    ////    // Act
    ////    var result = validator.TestValidate(req);
    ////    // Assert
    ////    result.ShouldHaveValidationErrorFor(req => req.MN_APPOINTMENT_DATE);
    ////}
    ////
    ////[Fact]
    ////public void Should_Error_when_Slot_is_NullOrEmpty()
    ////{
    ////    // Arrange
    ////    var req = GetTempSendCheckInLate();
    ////    req.MN_SLOT = "";
    ////    // Act
    ////    var result = validator.TestValidate(req);
    ////    // Assert
    ////    result.ShouldHaveValidationErrorFor(req => req.MN_SLOT);
    ////}
    ////
    ////[Fact]
    ////public void Should_Error_when_Package_is_NullOrEmpty()
    ////{
    ////    // Arrange
    ////    var req = GetTempSendCheckInLate();
    ////    req.MN_PACKAGE = "";
    ////    // Act
    ////    var result = validator.TestValidate(req);
    ////    // Assert
    ////    result.ShouldHaveValidationErrorFor(req => req.MN_PACKAGE);
    ////}
    ////
    ////[Fact]
    ////public void Should_Error_when_ProductName_is_NullOrEmpty()
    ////{
    ////    // Arrange
    ////    var req = GetTempSendCheckInLate();
    ////    req.MN_PRODUCT_NAME = "";
    ////    // Act
    ////    var result = validator.TestValidate(req);
    ////    // Assert
    ////    result.ShouldHaveValidationErrorFor(req => req.MN_PRODUCT_NAME);
    ////}
}


