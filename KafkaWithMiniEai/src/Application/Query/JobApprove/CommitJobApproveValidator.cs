using Application.Extension;
using FluentValidation;

namespace Application.Query.JobApprove;

public class CommitJobApproveValidator : AbstractValidator<CommitJobApproveRequestModel>
{
    public CommitJobApproveValidator()
    {
        RuleFor(x => x.internetNo)
            .NotNull().NotEmpty()
            .WithErrorCode("40001")
            .WithMessage(x => this.WithErrorMessage(nameof(x.internetNo)));

        RuleFor(x => x.orderNo)
            .NotNull().NotEmpty()
            .WithErrorCode("40002")
            .WithMessage(x => this.WithErrorMessage(nameof(x.orderNo)));

        RuleFor(x => x.approveTime)
            .NotNull().NotEmpty()
            .WithErrorCode("40003")
            .WithMessage(x => this.WithErrorMessage(nameof(x.approveTime)));
    }
}
