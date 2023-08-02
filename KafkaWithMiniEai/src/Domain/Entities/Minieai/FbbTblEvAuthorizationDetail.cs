namespace Domain.Entities.Minieai;

public partial class FbbTblEvAuthorizationDetail
{
    public long Id { get; set; }
    public long HeaderId { get; set; }
    public string? Username { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public string? Role { get; set; }
    public string? RolePast { get; set; }
    public string? Period { get; set; }
    public string? StartDate { get; set; }
    public string? EndDate { get; set; }
    public string? LocationCode { get; set; }
    public string? LocationName { get; set; }
    public string? Created { get; set; }
    public DateTime? CreatedDate { get; set; }
    public string? LastUpd { get; set; }
    public DateTime? LastUpdDate { get; set; }

    public virtual FbbTblEvAuthorizationHeader Header { get; set; } = null!;
}
