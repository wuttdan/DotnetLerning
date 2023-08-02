namespace Domain.Entities.Minieai
{
    public partial class FbbTblEvsendchecklateDetail
    {
        public long Id { get; set; }
        public long HeaderId { get; set; }
        public string? FieldName { get; set; }
        public int? TypeGroup { get; set; }
        public string? FieldValue { get; set; }
        public string? Created { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? LastUpd { get; set; }
        public DateTime? LastUpdDate { get; set; }

        public virtual FbbTblEvsendchecklateHeader Header { get; set; } = null!;
    }
}
