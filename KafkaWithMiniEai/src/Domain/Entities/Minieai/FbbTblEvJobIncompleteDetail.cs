namespace Domain.Entities.Minieai
{
    public partial class FbbTblEvJobIncompleteDetail
    {
        public long Id { get; set; }
        public long HeaderId { get; set; }
        public string? Reason { get; set; }
        public string? SubReason { get; set; }
        public string? Remark { get; set; }
        public string? AttributeValue { get; set; }
        public string? AttributeDesc { get; set; }
        public string? IncompleteTime { get; set; }
        public string? Created { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? LastUpd { get; set; }
        public DateTime? LastUpdDate { get; set; }

        public virtual FbbTblEvJobIncompleteHeader Header { get; set; } = null!;
    }
}
