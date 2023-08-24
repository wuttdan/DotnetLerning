namespace Application.Common.Models.Authorization;

public class AcimRequestUser
{
    public string? username { get; set; } = string.Empty;
    public string? firstName { get; set; }
    public string? lastName { get; set; }
    public string? email { get; set; }
    public string? role { get; set; }
    public string? rolePast { get; set; } = string.Empty;
    public string? period { get; set; }
    public string? startDate { get; set; }
    public string? endDate { get; set; }
    public string? locationCode { get; set; }
    public string? locationName { get; set; }
}
