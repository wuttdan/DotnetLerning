namespace Domain.Entities.Minieai
{
    public partial class FbbTblWoErrorMessage
    {
        public long Id { get; set; }
        public long? WoId { get; set; }
        public string? ErrorCode { get; set; }
        public string? ErrorDesc { get; set; }
        public string? Remark { get; set; }
        public string? Created { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? LastUpd { get; set; }
        public DateTime? LastUpdDate { get; set; }

        public virtual FbbTblWo? Wo { get; set; }
    }
}
