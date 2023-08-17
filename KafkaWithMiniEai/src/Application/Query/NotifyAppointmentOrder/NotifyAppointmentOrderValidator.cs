﻿using Application.Extension;
using FluentValidation;

namespace Application.Query.NotifyAppointmentOrder;

public class NotifyAppointmentOrderValidator : AbstractValidator<NotifyAppointmentOrderRequestModel>
{
    public NotifyAppointmentOrderValidator()
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
    }
}