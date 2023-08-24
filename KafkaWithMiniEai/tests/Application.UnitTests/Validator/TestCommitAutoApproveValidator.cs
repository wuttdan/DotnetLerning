using Application.Query.AutoApprove;
using Application.Query.JobApprove;
using Application.Query.JobIncomplete;
using Application.Query.Microsite;
using Application.Query.SendCheckInLate;
using Domain.Extension;
using FluentValidation.TestHelper;
using System.Security.Cryptography;
using Xunit;

namespace Application.UnitTests.Validator;

public sealed class TestCommitAutoApproveValidator : BaseApplicationUnitTest
{
    private CommitAutoApproveValidator validator = null;
    public TestCommitAutoApproveValidator()
    {
        // Arrange
        validator = new CommitAutoApproveValidator();
    }

    [Fact]
    public void Should_Pass_when_RequireProperty_is_HaveValue()
    {
        // Arrange
        var req = new CommitAutoApproveRequestModel { };
        // Act
        var result = validator.TestValidate(req);
        // Assert
        result.ShouldNotHaveAnyValidationErrors();
    }
}



