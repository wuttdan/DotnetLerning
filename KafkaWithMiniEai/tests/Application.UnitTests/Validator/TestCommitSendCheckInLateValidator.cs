﻿using Application.Query.SendCheckInLate;

namespace Application.UnitTests.Validator;

public sealed class TestCommitSendCheckInLateValidator : BaseApplicationUnitTest
{
    private CommitSendCheckInLateValidator validator;
    public TestCommitSendCheckInLateValidator(FixtureApplicationUnitTest appFixture)
        : base(appFixture)
    {
        // Arrange
        validator = new CommitSendCheckInLateValidator();
    }

    [Fact]
    public void Should_Error_when_FibrenetId_is_NullOrEmpty()
    {
        //// Arrange
        //var req = new CommitSendCheckInLateRequestModel
        //{
        //};
        //
        //// Act
        //var result = validator.TestValidate(req);
        //
        //// Assert
        //result.ShouldHaveValidationErrorFor(req => req.FIBRENET_ID);
    }
}


