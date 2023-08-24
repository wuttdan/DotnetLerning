using Application.Common.Models.Authorization;
using Application.Extension;
using FluentValidation;
using System;
using static System.Collections.Specialized.BitVector32;

namespace Application.Query.Authorization;

public sealed class CommitAuthorizationValidator : AbstractValidator<CommitAuthorizationRequestModel>
{
    public CommitAuthorizationValidator()
    {
        //RuleFor(x => x)
        //    .Must(ValidateUserWithAction);
        //.WithErrorCode("40001")
        //.WithMessage("'{0}' parameter(s) should not be null or empty.");
        //When(x => x.ACTION?.ToUpper() == "A" || x.ACTION?.ToUpper() == "U", () => {
        //    RuleFor(customer => customer.CustomerDiscount).GreaterThan(0);
        //    RuleFor(customer => customer.CreditCardNumber).NotNull();
        //});
        //
        //When(x => x.ACTION?.ToUpper() == "D", () => {
        //    RuleFor(customer => customer.CustomerDiscount).GreaterThan(0);
        //    RuleFor(customer => customer.CreditCardNumber).NotNull();
        //});
        RuleForEach(x => x.USERS).SetValidator(x => new AcimRequestUserValidator(x.ACTION));
    }
}

public sealed class AcimRequestUserValidator : AbstractValidator<AcimRequestUser>
{
    public AcimRequestUserValidator(string action = "")
    {
        When(x => action.ToUpper() == "D", () => {
            RuleFor(x => x.username).NotEmpty();
            RuleFor(x => x.role).NotEmpty();
        });

        When(x => action.ToUpper() == "A", () => 
        {
            RuleFor(x => x.username).NotEmpty();
            RuleFor(x => x.role).NotEmpty();
        });

        When(x => action.ToUpper() == "U", () =>
        {
            RuleFor(x => x.username).NotEmpty();
            RuleFor(x => x.role).NotEmpty();
        });
    }
}
