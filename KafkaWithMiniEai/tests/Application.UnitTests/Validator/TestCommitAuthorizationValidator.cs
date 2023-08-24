using Application.Query.Authorization;

namespace Application.UnitTests.Validator;

public sealed class TestCommitAuthorizationValidator : BaseApplicationUnitTest
{
    private CommitAuthorizationValidator validator = null;
    public TestCommitAuthorizationValidator()
    {
        // Arrange
        validator = new CommitAuthorizationValidator();
    }
}



