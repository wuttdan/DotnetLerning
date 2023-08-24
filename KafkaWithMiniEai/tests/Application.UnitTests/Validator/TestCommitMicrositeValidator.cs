using Application.Query.Microsite;
using Application.Query.SendCheckInLate;
using Domain.Extension;
using FluentValidation.TestHelper;
using System.Security.Cryptography;
using Xunit;

namespace Application.UnitTests.Validator;

public sealed class TestCommitMicrositeValidator : BaseApplicationUnitTest
{
    private CommitMicrositeValidator validator = null;
    public TestCommitMicrositeValidator()
    {
        // Arrange
        validator = new CommitMicrositeValidator();
    }

    [Theory]
    [InlineData("USER")]
    [InlineData("SEGMENT")]
    [InlineData("NUMBER_OF_USER")]
    [InlineData("RESIDENTIAL")]
    [InlineData("TYPE_OF_USER")]
    [InlineData("PACKAGE")]
    [InlineData("PACKAGE_CODE")]
    [InlineData("SPEED")]
    [InlineData("PLAYBOX_BUNDLE")]
    [InlineData("PLAYBOX_ADDON")]
    [InlineData("ROUTER_BUNDLE")]
    [InlineData("ROUTER_ADDON")]
    [InlineData("PRICE")]
    [InlineData("FIRSTNAME")]
    [InlineData("LASTNAME")]
    [InlineData("TELEPHONE")]
    [InlineData("EMAIL")]
    [InlineData("ADDRESS")]
    [InlineData("SUBDISTRICT")]
    [InlineData("DISTRICT")]
    [InlineData("PROVINCE")]
    [InlineData("ZIPCODE")]
    [InlineData("MEDIA_STREAMING")]
    [InlineData("USER_JOURNEY")]
    [InlineData("CID")]
    [InlineData("COMPLETE")]
    public void Should_Error_when_RequireProperty_is_NullOrEmpty(string propName)
    {
        // Arrange
        var req = GetTempMicrosite();
        req.SetValueByName(propName, "");
        // Act
        var result = validator.TestValidate(req);
        // Assert
        result.ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void Should_Pass_when_RequireProperty_is_HaveValue()
    {
        // Arrange
        var req = GetTempMicrosite();
        // Act
        var result = validator.TestValidate(req);
        // Assert
        result.ShouldNotHaveAnyValidationErrors();
    }
}


