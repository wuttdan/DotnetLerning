using Application.Query.JobApprove;
using Application.Query.JobIncomplete;
using Application.Query.Microsite;
using Application.Query.SendCheckInLate;
using Domain.Extension;
using FluentValidation.TestHelper;
using System.Security.Cryptography;
using Xunit;

namespace Application.UnitTests.Validator;

public sealed class TestCommitJobApproveValidator : BaseApplicationUnitTest
{
    private CommitJobApproveValidator validator = null;
    public TestCommitJobApproveValidator()
    {
        // Arrange
        validator = new CommitJobApproveValidator();
    }

    [Theory]
    [InlineData("internetNo")]
    [InlineData("orderNo")]
    [InlineData("approveTime")]
    public void Should_Error_when_RequireProperty_is_NullOrEmpty(string propName)
    {
        // Arrange
        var req = GetTempJobApprove();
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
        var req = GetTempJobApprove();
        // Act
        var result = validator.TestValidate(req);
        // Assert
        result.ShouldNotHaveAnyValidationErrors();
    }
}


