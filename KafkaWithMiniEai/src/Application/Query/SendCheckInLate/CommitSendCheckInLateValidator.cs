using Application.Common.Core;
using Application.Extension;
using FluentValidation;
using System.ComponentModel;

namespace Application.Query.SendCheckInLate;

public class CommitSendCheckInLateValidator : AbstractValidator<CommitSendCheckInLateRequestModel>
{

    private readonly List<string> ListValidateProperties = new()
    {
        "MN_INTERNET_ID",
        "MN_ORDER_NO",
        "MN_APPOINTMENT_DATE",
        "MN_SLOT",
        "MN_PACKAGE",
        "MN_PRODUCT_NAME",
        "MN_ORDER_TYPE",
        "MN_CUSTOMER_NAME",
        "MN_CUSTOMER_ADDRESS",
        "MN_CUSTOMER_LATITUDE",
        "MN_CUSTOMER_LONGITUDE",
        "MN_REGION",
        "MN_STAFF_CODE",
        "MN_STAFF_NAME",
        "MN_STAFF_PHONE",
        "MN_SUBCONTRACT_TEAM",
        "MN_CHECKIN_LATE_TIME",
        "MN_CHECKIN_LATE_REASON",
        "MN_CURRENT_LATITUDE",
        "MN_CURRENT_LONGITUDE",
        "MN_CREATE_DATE",
        "MN_CREATED_BY",
        "MN_CUSTOMER_CONTACT_1",
        //"MN_CUSTOMER_CONTACT_2",
        //"MN_CUSTOMER_CONTACT_3",
        "MN_REMARKS"
    };
    private string ValidateErrorMessage = string.Empty;
    public CommitSendCheckInLateValidator()
    {
        RuleFor(x => x.MN_INTERNET_ID).NotNull().NotEmpty().WithErrorCode("50101").WithMessage(x => this.WithErrorMessage(nameof(x.MN_INTERNET_ID)));
        RuleFor(x => x.MN_ORDER_NO).NotNull().NotEmpty().WithErrorCode("50101").WithMessage(x => this.WithErrorMessage(nameof(x.MN_ORDER_NO)));
        RuleFor(x => x.MN_APPOINTMENT_DATE).NotNull().NotEmpty().WithErrorCode("50101").WithMessage(x => this.WithErrorMessage(nameof(x.MN_APPOINTMENT_DATE)));
        RuleFor(x => x.MN_SLOT).NotNull().NotEmpty().WithErrorCode("50101").WithMessage(x => this.WithErrorMessage(nameof(x.MN_SLOT)));
        RuleFor(x => x.MN_PACKAGE).NotNull().NotEmpty().WithErrorCode("50101").WithMessage(x => this.WithErrorMessage(nameof(x.MN_PACKAGE)));
        RuleFor(x => x.MN_PRODUCT_NAME).NotNull().NotEmpty().WithErrorCode("50101").WithMessage(x => this.WithErrorMessage(nameof(x.MN_PRODUCT_NAME)));
        RuleFor(x => x.MN_ORDER_TYPE).NotNull().NotEmpty().WithErrorCode("50101").WithMessage(x => this.WithErrorMessage(nameof(x.MN_ORDER_TYPE)));
        RuleFor(x => x.MN_CUSTOMER_NAME).NotNull().NotEmpty().WithErrorCode("50101").WithMessage(x => this.WithErrorMessage(nameof(x.MN_CUSTOMER_NAME)));
        RuleFor(x => x.MN_CUSTOMER_ADDRESS).NotNull().NotEmpty().WithErrorCode("50101").WithMessage(x => this.WithErrorMessage(nameof(x.MN_CUSTOMER_ADDRESS)));
        RuleFor(x => x.MN_CUSTOMER_LATITUDE).NotNull().NotEmpty().WithErrorCode("50101").WithMessage(x => this.WithErrorMessage(nameof(x.MN_CUSTOMER_LATITUDE)));
        RuleFor(x => x.MN_CUSTOMER_LONGITUDE).NotNull().NotEmpty().WithErrorCode("50101").WithMessage(x => this.WithErrorMessage(nameof(x.MN_CUSTOMER_LONGITUDE)));
        RuleFor(x => x.MN_REGION).NotNull().NotEmpty().WithErrorCode("50101").WithMessage(x => this.WithErrorMessage(nameof(x.MN_REGION)));
        RuleFor(x => x.MN_STAFF_CODE).NotNull().NotEmpty().WithErrorCode("50101").WithMessage(x => this.WithErrorMessage(nameof(x.MN_STAFF_CODE)));
        RuleFor(x => x.MN_STAFF_NAME).NotNull().NotEmpty().WithErrorCode("50101").WithMessage(x => this.WithErrorMessage(nameof(x.MN_STAFF_NAME)));
        RuleFor(x => x.MN_STAFF_PHONE).NotNull().NotEmpty().WithErrorCode("50101").WithMessage(x => this.WithErrorMessage(nameof(x.MN_STAFF_PHONE)));
        RuleFor(x => x.MN_SUBCONTRACT_TEAM).NotNull().NotEmpty().WithErrorCode("50101").WithMessage(x => this.WithErrorMessage(nameof(x.MN_SUBCONTRACT_TEAM)));
        RuleFor(x => x.MN_CHECKIN_LATE_TIME).NotNull().NotEmpty().WithErrorCode("50101").WithMessage(x => this.WithErrorMessage(nameof(x.MN_CHECKIN_LATE_TIME)));
        RuleFor(x => x.MN_CHECKIN_LATE_REASON).NotNull().NotEmpty().WithErrorCode("50101").WithMessage(x => this.WithErrorMessage(nameof(x.MN_CHECKIN_LATE_REASON)));
        RuleFor(x => x.MN_CURRENT_LATITUDE).NotNull().NotEmpty().WithErrorCode("50101").WithMessage(x => this.WithErrorMessage(nameof(x.MN_CURRENT_LATITUDE)));
        RuleFor(x => x.MN_CURRENT_LONGITUDE).NotNull().NotEmpty().WithErrorCode("50101").WithMessage(x => this.WithErrorMessage(nameof(x.MN_CURRENT_LONGITUDE)));
        RuleFor(x => x.MN_CREATE_DATE).NotNull().NotEmpty().WithErrorCode("50101").WithMessage(x => this.WithErrorMessage(nameof(x.MN_CREATE_DATE)));
        RuleFor(x => x.MN_CREATED_BY).NotNull().NotEmpty().WithErrorCode("50101").WithMessage(x => this.WithErrorMessage(nameof(x.MN_CREATED_BY)));
        RuleFor(x => x.MN_CUSTOMER_CONTACT_1).NotNull().NotEmpty().WithErrorCode("50101").WithMessage(x => this.WithErrorMessage(nameof(x.MN_CUSTOMER_CONTACT_1)));
        RuleFor(x => x.MN_REMARKS).NotNull().NotEmpty().WithErrorCode("50101").WithMessage(x => this.WithErrorMessage(nameof(x.MN_REMARKS)));
    }
}
