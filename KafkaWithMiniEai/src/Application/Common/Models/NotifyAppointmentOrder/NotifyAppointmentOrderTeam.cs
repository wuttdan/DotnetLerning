using Domain.Common.Core;

namespace Application.Common.Models.NotifyAppointmentOrder;

public sealed class NotifyAppointmentOrderTeam : BracketModel
{
    public string? TEAM_NAME { get; set; }
    public string? TEAM_ID { get; set; }
    public string? TEAM_SERVICE { get; set; }
    public string? VENDOR_CODE { get; set; }
    public string? LOCATION_CODE { get; set; }
    public string? STORAGE_LOCATION { get; set; }
    public string? SHIP_TO { get; set; }
}
