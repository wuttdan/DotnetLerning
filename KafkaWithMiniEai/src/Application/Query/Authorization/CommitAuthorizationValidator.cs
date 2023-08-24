using Application.Common.Models.Authorization;
using Application.Extension;
using FluentValidation;
using System;

namespace Application.Query.Authorization;

public sealed class CommitAuthorizationValidator : AbstractValidator<CommitAuthorizationRequestModel>
{
    public CommitAuthorizationValidator()
    {
        RuleFor(x => x)
            .Must(ValidateUserWithAction);
            //.WithErrorCode("40001")
            //.WithMessage("'{0}' parameter(s) should not be null or empty.");
    }

    private bool ValidateUserWithAction(CommitAuthorizationRequestModel req)
    {
        if (req?.ACTION?.ToUpper() == "A")
        {
            RuleForEach(x => x.USERS).SetValidator(new AcimRequestUserInsertValidator());
        }
        else if (req?.ACTION?.ToUpper() == "A")
        {
            RuleForEach(x => x.USERS).SetValidator(new AcimRequestUserUpdateValidator());
        }
        return true;
    }
}

public sealed class AcimRequestUserInsertValidator : AcimRequestUserValidator
{
    public AcimRequestUserInsertValidator() 
        : base() { }
}

public sealed class AcimRequestUserUpdateValidator : AcimRequestUserValidator
{
    public AcimRequestUserUpdateValidator() 
        : base() { }
}

public class AcimRequestUserValidator : AbstractValidator<AcimRequestUser>
{
    public AcimRequestUserValidator()
    {
        
    }
}

