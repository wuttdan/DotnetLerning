namespace Domain.Entities.Minieai
{
    public partial class FbbTblEvJobApproveDetail
    {
        public long Id { get; set; }
        public long HeaderId { get; set; }
        public string? ApproveTime { get; set; }
        public string? Created { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? LastUpd { get; set; }
        public DateTime? LastUpdDate { get; set; }

        public virtual FbbTblEvJobApproveHeader Header { get; set; } = null!;
    }
}
