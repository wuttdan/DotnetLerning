using Application.Extension;
using FluentValidation;

namespace Application.Query.JobIncomplete;

public sealed class CommitJobIncompleteValidator : AbstractValidator<CommitJobIncompleteRequestModel>
{
    public CommitJobIncompleteValidator()
    {
        RuleFor(x => x.internetNo)
            .NotNull().NotEmpty()
            .WithErrorCode("40001")
            .WithMessage(x => this.WithErrorMessage(nameof(x.internetNo)));

        RuleFor(x => x.orderNo)
            .NotNull().NotEmpty()
            .WithErrorCode("40002")
            .WithMessage(x => this.WithErrorMessage(nameof(x.orderNo)));

        RuleFor(x => x.reason)
            .NotNull().NotEmpty()
            .WithErrorCode("40003")
            .WithMessage(x => this.WithErrorMessage(nameof(x.reason)));

        RuleFor(x => x.subReason)
            .NotNull().NotEmpty()
            .WithErrorCode("40004")
            .WithMessage(x => this.WithErrorMessage(nameof(x.subReason)));

        RuleFor(x => x.incompleteTime)
            .NotNull().NotEmpty()
            .WithErrorCode("40005")
            .WithMessage(x => this.WithErrorMessage(nameof(x.incompleteTime)));
    }
}
