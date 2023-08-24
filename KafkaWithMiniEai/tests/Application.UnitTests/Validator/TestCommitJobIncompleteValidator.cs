using Application.Query.JobIncomplete;
using Application.Query.Microsite;
using Application.Query.SendCheckInLate;
using Domain.Extension;
using FluentValidation.TestHelper;
using System.Security.Cryptography;
using Xunit;

namespace Application.UnitTests.Validator;

public sealed class TestCommitJobIncompleteValidator : BaseApplicationUnitTest
{
    private CommitJobIncompleteValidator validator = null;
    public TestCommitJobIncompleteValidator()
    {
        // Arrange
        validator = new CommitJobIncompleteValidator();
    }

    [Theory]
    [InlineData("internetNo")]
    [InlineData("orderNo")]
    [InlineData("reason")]
    [InlineData("subReason")]
    [InlineData("incompleteTime")]
    public void Should_Error_when_RequireProperty_is_NullOrEmpty(string propName)
    {
        // Arrange
        var req = GetTempJobIncomplete();
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
        var req = GetTempJobIncomplete();
        // Act
        var result = validator.TestValidate(req);
        // Assert
        result.ShouldNotHaveAnyValidationErrors();
    }
}


