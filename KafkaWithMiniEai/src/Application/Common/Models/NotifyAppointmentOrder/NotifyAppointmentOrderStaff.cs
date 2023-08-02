using Domain.Common.Core;

namespace Application.Common.Models.NotifyAppointmentOrder;

public sealed class NotifyAppointmentOrderStaff : BracketModel
{
    public string? STAFF_CODE { get; set; }
    public string? STAFF_NAME { get; set; }
    public string? STAFF_PHONE { get; set; }
    public string? STAFF_EMAIL { get; set; }
    public string? STAFF_LATITUDE { get; set; }
    public string? STAFF_LONGITUDE { get; set; }
    public string? STAFF_FIRST_DAY_WORKING { get; set; }
    public string? STAFF_END_DAY_WORKING { get; set; }
    public string? STAFF_ROLE { get; set; }
    public string? STAFF_PROFILE_PICTURE_FILENAME { get; set; }
    public List<NotifyAppointmentOrderCompany>? COMPANY_LIST { get; set; }
}