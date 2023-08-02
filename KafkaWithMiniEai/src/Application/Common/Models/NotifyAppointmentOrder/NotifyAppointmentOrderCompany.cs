using Domain.Common.Core;

namespace Application.Common.Models.NotifyAppointmentOrder;

public sealed class NotifyAppointmentOrderCompany : BracketModel
{
    public string? COMPANY_NAME { get; set; }
    public string? COMPANY_ID { get; set; }
    public string? VENDOR_CODE { get; set; }
    public string? LOCATION_CODE { get; set; }
    public string? STORAGE_LOCATION { get; set; }
    public List<NotifyAppointmentOrderTeam>? TEAM_LIST { get; set; }
}
