namespace Domain.Entities.Minieai;

public partial class FbbTblEvAutoApproveHeader
{
    public long Id { get; set; }
    public string? TransactionId { get; set; }
    public string? Timestamp { get; set; }
    public string? Status { get; set; }
    public string? Created { get; set; }
    public DateTime? CreatedDate { get; set; }
    public string? LastUpd { get; set; }
    public DateTime? LastUpdDate { get; set; }
    public string? ServerName { get; set; }
}
