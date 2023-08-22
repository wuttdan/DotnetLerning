using Application.Common.Core;
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
        RuleFor(x => x)
            .Must(ValidateAllProperty)
            .WithErrorCode("50101")
            .WithMessage(ValidateErrorMessage);
    }

    private bool ValidateAllProperty(CommitSendCheckInLateRequestModel model)
    {
        PropertyDescriptorCollection pdc = TypeDescriptor.GetProperties(model);
        foreach (string pp in ListValidateProperties)
        {
            var pd = pdc[pp];
            var value = pd?.GetValue(model) ?? null;
            if (value is string && string.IsNullOrEmpty((string)value))
            {
                ValidateErrorMessage = string.Format(AppConstant.DefValidateErrorFormat, pp);
                return false;
            }
            else if (value is null)
            {
                ValidateErrorMessage = string.Format(AppConstant.DefValidateErrorFormat, pp);
                return false;
            }
        }
        ValidateErrorMessage = string.Empty;
        return true;
    }
}
