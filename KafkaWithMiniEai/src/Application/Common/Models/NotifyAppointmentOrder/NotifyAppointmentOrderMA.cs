using Newtonsoft.Json;

namespace Application.Common.Models.NotifyAppointmentOrder;

public sealed class NotifyAppointmentOrderMa : NotifyAppointmentOrderType
{
    public string? TROUBLE_TICKET_NO { get; set; }
    public string? SIEBEL_REQUEST_NO { get; set; }
    public string? TASK_ORDER_NO { get; set; }
    public string? FIBRENET_ID { get; set; }
    public string? JOB_STATE { get; set; }
    public string? JOB_PRIORITY { get; set; }
    public string? PRODUCT_NAME { get; set; }
    public string? SERVICE { get; set; }
    public string? ACCESS_MODE { get; set; }
    public string? DOWNLINK_RATE { get; set; }
    public string? UPLINK_RATE { get; set; }
    public string? COMMIT_DATE { get; set; }
    public string? ACCEPT_DATE { get; set; }
    public string? TROUBLE_SYMPTOM { get; set; }
    public string? COMPLAINT_TITLE { get; set; }
    public string? CUSTOMER_COMPLAINT_NAME { get; set; }
    public string? CUSTOMER_COMPLAINT_MOBILE { get; set; }
    public string? NOC_REMARK { get; set; }
    public string? NOC_NUMBER { get; set; }
    public string? DETAILS_FOR_RESOLVED { get; set; }
    public string? COMPLAINT_DESCRIPTION { get; set; }
    public string? CUSTOMER_NAME { get; set; }
    public string? CONTACT_PERSON_NAME { get; set; }
    public string? CONTACT_MOBILE_PHONE1 { get; set; }
    public string? CONTACT_MOBILE_PHONE2 { get; set; }
    public string? CONTACT_MOBILE_PHONE3 { get; set; }
    public string? APPOINTMENT_DATE { get; set; }
    public string? APPOINTMENT_TIMESLOT { get; set; }

    /**
     * R23.01
     **/
    [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
    public string? INSTALLATION_ADDRESS { get; set; }
    public string? ADDRESS { get; set; }
    public string? INSTALLATION_LATITUDE { get; set; }
    public string? INSTALLATION_LONGITUDE { get; set; }
    public string? SERVICE_PACK { get; set; }
    public string? SERVICE_LEVEL { get; set; }
    public string? ONTOP_PACK { get; set; }
    public string? PLAYBOX_CONTENT { get; set; }

    public List<NotifyAppointmentOrderWfm>? WFM_SUBCONTRACT_REMARKS { get; set; }
    public List<NotifyAppointmentOrderStaff>? STAFF_LIST { get; set; }
    public NotifyAppointmentOrderResource? RESOURCE { get; set; }
}