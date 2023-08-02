namespace Application.Common.Models.NotifyAppointmentOrder;

public sealed class NotifyAppointmentOrderInstall : NotifyAppointmentOrderType
{
    public string? CUSTOMER_ORDER_NO { get; set; }
    public string? FBSS_ORDER_NO { get; set; }
    public string? TASK_ORDER_NO { get; set; }
    public string? FIBRENET_ID { get; set; }
    public string? JOB_STATE { get; set; }
    public string? JOB_PRIORITY { get; set; }
    public string? PRODUCT_NAME { get; set; }
    public string? ACCESS_MODE { get; set; }
    public string? ORDER_TYPE { get; set; }
    public string? REPLACE_ONT_FLAG { get; set; }
    public string? REPLACE_ROUTER_FLAG { get; set; }
    public string? ROUTER_NUM { get; set; }
    public string? CUSTOMER_NAME { get; set; }
    public string? CONTACT_PERSON_NAME { get; set; }
    public string? CONTACT_MOBILE_PHONE1 { get; set; }
    public string? CONTACT_MOBILE_PHONE2 { get; set; }
    public string? CONTACT_MOBILE_PHONE3 { get; set; }
    public string? INSTALLATION_ADDRESS { get; set; }
    public string? INSTALLATION_LATITUDE { get; set; }
    public string? INSTALLATION_LONGITUDE { get; set; }
    public string? BRAND { get; set; }
    public string? EVENTFLOW_FLAG { get; set; }
    public string? SERVICE_LEVEL { get; set; }
    public string? ONTOP_PACK { get; set; }
    public string? SERVICE_PACK { get; set; }
    public string? VOIP_NUMBER1 { get; set; }
    public string? VOIP_PASSWORD1 { get; set; }
    public string? VOIP_NUMBER2 { get; set; }
    public string? VOIP_PASSWORD2 { get; set; }
    public string? PLAYBOX_CONTENT { get; set; }
    public List<string>? FEE_LIST { get; set; }
    public string? TOTAL_FEE { get; set; }
    public List<string>? SERVICE_ONTOP { get; set; }
    public string? APPOINTMENT_DATE { get; set; }
    public string? APPOINTMENT_TIMESLOT { get; set; }
    public List<NotifyAppointmentOrderCrm>? CRM_SUBCONTRACT_REMARKS { get; set; }
    public List<NotifyAppointmentOrderWfm>? WFM_SUBCONTRACT_REMARKS { get; set; }
    public List<NotifyAppointmentOrderStaff>? STAFF_LIST { get; set; }
    public NotifyAppointmentOrderResource? RESOURCE { get; set; }
}