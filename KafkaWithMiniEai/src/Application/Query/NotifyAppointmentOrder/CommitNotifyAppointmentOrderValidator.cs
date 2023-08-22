using Application.Common.Interfaces;
using Application.Extension;
using FluentValidation;

namespace Application.Query.NotifyAppointmentOrder;

public class CommitNotifyAppointmentOrderValidator : AbstractValidator<CommitNotifyAppointmentOrderRequestModel>
{
    public CommitNotifyAppointmentOrderValidator()
    {
        RuleFor(x => x.FIBRENET_ID)
            .NotNull().NotEmpty()
            .WithErrorCode("40003")
            .WithMessage(x => this.WithErrorMessage(nameof(x.FIBRENET_ID)));

        RuleFor(x => x.TYPE)
            .NotNull().NotEmpty()
            .WithErrorCode("40004")
            .WithMessage(x => this.WithErrorMessage(nameof(x.TYPE)));

        RuleFor(x => x.TYPE_OPER_DATE)
            .NotNull().NotEmpty()
            .WithErrorCode("40005")
            .WithMessage(x => this.WithErrorMessage(nameof(x.TYPE_OPER_DATE)));

        RuleFor(x => x.MSG_SEQ_ID)
            .NotNull().NotEmpty()
            .WithErrorCode("40006")
            .WithMessage(x => this.WithErrorMessage(nameof(x.MSG_SEQ_ID)));

        RuleFor(x => x)
            .Must(ValidateInstallOrderAndMaOrder)
            .WithErrorCode("40007")
            .WithMessage("'INSTALL_ORDER' and 'MA_ORDER' should not be dual null or empty.");
    }

    private bool ValidateInstallOrderAndMaOrder(CommitNotifyAppointmentOrderRequestModel req)
    {
        if (req?.MA_ORDER == null && req?.INSTALL_ORDER == null)
        {
            return false;
        }
        return true;
    }
}