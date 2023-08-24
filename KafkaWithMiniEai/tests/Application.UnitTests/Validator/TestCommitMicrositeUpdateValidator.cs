using Application.Query.Microsite;
using Application.Query.SendCheckInLate;
using Domain.Extension;
using FluentValidation.TestHelper;
using System.Security.Cryptography;
using Xunit;

namespace Application.UnitTests.Validator;

public sealed class TestCommitMicrositeUpdateValidator : BaseApplicationUnitTest
{
    private CommitMicrositeUpdateValidator validator = null;
    public TestCommitMicrositeUpdateValidator()
    {
        // Arrange
        validator = new CommitMicrositeUpdateValidator();
    }

    [Theory]
    [InlineData("ORDER_NO")]
    [InlineData("ORDER_CHANNEL")]
    [InlineData("IS_CONTACT_CUSTOMER")]
    [InlineData("USER_ACTION")]
    [InlineData("DATE_ACTION")]
    [InlineData("ORDER_PRE_REGISTER")]
    [InlineData("STATUS_ORDER")]

    public void Should_Error_when_RequireProperty_is_NullOrEmpty(string propName)
    {
        // Arrange
        var req = GetTempMicrositeUpdate();
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
        var req = GetTempMicrositeUpdate();
        // Act
        var result = validator.TestValidate(req);
        // Assert
        result.ShouldNotHaveAnyValidationErrors();
    }
}


