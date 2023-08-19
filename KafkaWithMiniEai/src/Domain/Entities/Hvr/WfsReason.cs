using Microsoft.EntityFrameworkCore;

namespace Domain.Entities.Hvr;

[Keyless]
public class WfsReason
{
    public string? REASON_CODE { get; set; }
    public string? REASON_NAME { get; set; }
}
