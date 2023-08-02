namespace Domain.Entities.Minieai
{
    public partial class FbbTblWoAttribute
    {
        public long Id { get; set; }
        public long? WoId { get; set; }
        public string? Name { get; set; }
        public string? Value { get; set; }
        public int? TypeGroup { get; set; }
        public string? Created { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? LastUpd { get; set; }
        public DateTime? LastUpdDate { get; set; }

        public virtual FbbTblWo? Wo { get; set; }
    }
}
