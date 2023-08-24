using Application.Common.Core;
using Application.Extension;
using FluentValidation;
using System.ComponentModel;

namespace Application.Query.SendCheckInLate;

public class CommitSendCheckInLateValidator : AbstractValidator<CommitSendCheckInLateRequestModel>
{
    public CommitSendCheckInLateValidator()
    {
        RuleFor(x => x.MN_INTERNET_ID).NotEmpty().WithErrorCode("50101").WithMessage(x => this.WithErrorMessage(nameof(x.MN_INTERNET_ID)));
        RuleFor(x => x.MN_ORDER_NO).NotEmpty().WithErrorCode("50101").WithMessage(x => this.WithErrorMessage(nameof(x.MN_ORDER_NO)));
        RuleFor(x => x.MN_APPOINTMENT_DATE).NotEmpty().WithErrorCode("50101").WithMessage(x => this.WithErrorMessage(nameof(x.MN_APPOINTMENT_DATE)));
        RuleFor(x => x.MN_SLOT).NotEmpty().WithErrorCode("50101").WithMessage(x => this.WithErrorMessage(nameof(x.MN_SLOT)));
        RuleFor(x => x.MN_PACKAGE).NotEmpty().WithErrorCode("50101").WithMessage(x => this.WithErrorMessage(nameof(x.MN_PACKAGE)));
        RuleFor(x => x.MN_PRODUCT_NAME).NotEmpty().WithErrorCode("50101").WithMessage(x => this.WithErrorMessage(nameof(x.MN_PRODUCT_NAME)));
        RuleFor(x => x.MN_ORDER_TYPE).NotEmpty().WithErrorCode("50101").WithMessage(x => this.WithErrorMessage(nameof(x.MN_ORDER_TYPE)));
        RuleFor(x => x.MN_CUSTOMER_NAME).NotEmpty().WithErrorCode("50101").WithMessage(x => this.WithErrorMessage(nameof(x.MN_CUSTOMER_NAME)));
        RuleFor(x => x.MN_CUSTOMER_ADDRESS).NotEmpty().WithErrorCode("50101").WithMessage(x => this.WithErrorMessage(nameof(x.MN_CUSTOMER_ADDRESS)));
        RuleFor(x => x.MN_CUSTOMER_LATITUDE).NotEmpty().WithErrorCode("50101").WithMessage(x => this.WithErrorMessage(nameof(x.MN_CUSTOMER_LATITUDE)));
        RuleFor(x => x.MN_CUSTOMER_LONGITUDE).NotEmpty().WithErrorCode("50101").WithMessage(x => this.WithErrorMessage(nameof(x.MN_CUSTOMER_LONGITUDE)));
        RuleFor(x => x.MN_REGION).NotEmpty().WithErrorCode("50101").WithMessage(x => this.WithErrorMessage(nameof(x.MN_REGION)));
        RuleFor(x => x.MN_STAFF_CODE).NotEmpty().WithErrorCode("50101").WithMessage(x => this.WithErrorMessage(nameof(x.MN_STAFF_CODE)));
        RuleFor(x => x.MN_STAFF_NAME).NotEmpty().WithErrorCode("50101").WithMessage(x => this.WithErrorMessage(nameof(x.MN_STAFF_NAME)));
        RuleFor(x => x.MN_STAFF_PHONE).NotEmpty().WithErrorCode("50101").WithMessage(x => this.WithErrorMessage(nameof(x.MN_STAFF_PHONE)));
        RuleFor(x => x.MN_SUBCONTRACT_TEAM).NotEmpty().WithErrorCode("50101").WithMessage(x => this.WithErrorMessage(nameof(x.MN_SUBCONTRACT_TEAM)));
        RuleFor(x => x.MN_CHECKIN_LATE_TIME).NotEmpty().WithErrorCode("50101").WithMessage(x => this.WithErrorMessage(nameof(x.MN_CHECKIN_LATE_TIME)));
        RuleFor(x => x.MN_CHECKIN_LATE_REASON).NotEmpty().WithErrorCode("50101").WithMessage(x => this.WithErrorMessage(nameof(x.MN_CHECKIN_LATE_REASON)));
        RuleFor(x => x.MN_CURRENT_LATITUDE).NotEmpty().WithErrorCode("50101").WithMessage(x => this.WithErrorMessage(nameof(x.MN_CURRENT_LATITUDE)));
        RuleFor(x => x.MN_CURRENT_LONGITUDE).NotEmpty().WithErrorCode("50101").WithMessage(x => this.WithErrorMessage(nameof(x.MN_CURRENT_LONGITUDE)));
        RuleFor(x => x.MN_CREATE_DATE).NotEmpty().WithErrorCode("50101").WithMessage(x => this.WithErrorMessage(nameof(x.MN_CREATE_DATE)));
        RuleFor(x => x.MN_CREATED_BY).NotEmpty().WithErrorCode("50101").WithMessage(x => this.WithErrorMessage(nameof(x.MN_CREATED_BY)));
        RuleFor(x => x.MN_CUSTOMER_CONTACT_1).NotEmpty().WithErrorCode("50101").WithMessage(x => this.WithErrorMessage(nameof(x.MN_CUSTOMER_CONTACT_1)));
        RuleFor(x => x.MN_REMARKS).NotEmpty().WithErrorCode("50101").WithMessage(x => this.WithErrorMessage(nameof(x.MN_REMARKS)));
    }
}
