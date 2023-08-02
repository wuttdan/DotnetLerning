namespace Domain.Entities.Minieai
{
    public partial class FbbTblWoSoaCrm
    {
        public long Id { get; set; }
        public long? WoId { get; set; }
        public int? Group { get; set; }
        public string? Author { get; set; }
        public string? SubcontractRemarks { get; set; }
        public string? RemarkDate { get; set; }
        public string? Created { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? LastUpd { get; set; }
        public DateTime? LastUpdDate { get; set; }

        public virtual FbbTblWo? Wo { get; set; }
    }
}
