using Application.Common.Core;
using Application.Query.SendCheckInLate;
using Newtonsoft.Json;

namespace Application.Common.Models.SendCheckInLate;

public class SendCheckInLateRequestBase : RequestBase
{
    [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
    public string? MN_TRANSACTION_ID { get; set; }

    public string? MN_INTERNET_ID { get; set; }
    public string? MN_ORDER_NO { get; set; }
    public string? MN_APPOINTMENT_DATE { get; set; }
    public string? MN_SLOT { get; set; }
    public string? MN_PACKAGE { get; set; }
    public string? MN_PRODUCT_NAME { get; set; }
    public string? MN_ORDER_TYPE { get; set; }
    public string? MN_CUSTOMER_NAME { get; set; }
    public string? MN_CUSTOMER_CONTACT_1 { get; set; }
    public string? MN_CUSTOMER_CONTACT_2 { get; set; }
    public string? MN_CUSTOMER_CONTACT_3 { get; set; }
    public string? MN_CUSTOMER_ADDRESS { get; set; }
    public string? MN_CUSTOMER_LATITUDE { get; set; }
    public string? MN_CUSTOMER_LONGITUDE { get; set; }
    public string? MN_REGION { get; set; }
    public string? MN_STAFF_CODE { get; set; }
    public string? MN_STAFF_NAME { get; set; }
    public string? MN_STAFF_PHONE { get; set; }
    public string? MN_SUBCONTRACT_TEAM { get; set; }
    public string? MN_CHECKIN_LATE_TIME { get; set; }
    public string? MN_CHECKIN_LATE_REASON { get; set; }
    public string? MN_REMARKS { get; set; }
    public string? MN_CURRENT_LATITUDE { get; set; }
    public string? MN_CURRENT_LONGITUDE { get; set; }
    public string? MN_CREATE_DATE { get; set; }
    public string? MN_CREATED_BY { get; set; }

    public CommitSendCheckInLateResponseModel CreateResponse(string resultDesc = "", string resultCode = "")
    {
        return new CommitSendCheckInLateResponseModel
        {
            TRANSACTION_ID = TransactionId,
            RESULT_CODE = resultCode,
            RESULT_DESC = resultDesc
        };
    }
}
