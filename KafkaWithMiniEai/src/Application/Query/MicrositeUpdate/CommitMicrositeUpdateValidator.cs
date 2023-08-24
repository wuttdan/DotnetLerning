using Application.Extension;
using FluentValidation;

namespace Application.Query.Microsite;

public sealed class CommitMicrositeUpdateValidator : AbstractValidator<CommitMicrositeUpdateRequestModel>
{
    public CommitMicrositeUpdateValidator()
    {
        RuleFor(x => x.ORDER_NO)
            .NotEmpty()
            .WithErrorCode("40001")
            .WithMessage(x => this.WithErrorMessage(nameof(x.ORDER_NO)));

        RuleFor(x => x.ORDER_CHANNEL)
            .NotEmpty()
            .WithErrorCode("40002")
            .WithMessage(x => this.WithErrorMessage(nameof(x.ORDER_CHANNEL)));

        RuleFor(x => x.IS_CONTACT_CUSTOMER)
            .NotEmpty()
            .WithErrorCode("40003")
            .WithMessage(x => this.WithErrorMessage(nameof(x.IS_CONTACT_CUSTOMER)));

        RuleFor(x => x.USER_ACTION)
            .NotEmpty()
            .WithErrorCode("40005")
            .WithMessage(x => this.WithErrorMessage(nameof(x.USER_ACTION)));

        RuleFor(x => x.DATE_ACTION)
            .NotEmpty()
            .WithErrorCode("40006")
            .WithMessage(x => this.WithErrorMessage(nameof(x.DATE_ACTION)));

        RuleFor(x => x.ORDER_PRE_REGISTER)
            .NotEmpty()
            .WithErrorCode("40007")
            .WithMessage(x => this.WithErrorMessage(nameof(x.ORDER_PRE_REGISTER)));

        RuleFor(x => x.STATUS_ORDER)
            .NotEmpty()
            .WithErrorCode("40008")
            .WithMessage(x => this.WithErrorMessage(nameof(x.STATUS_ORDER)));
    }
}
