namespace Domain.Entities.Minieai
{
    public partial class FbbTblMappingId
    {
        public FbbTblMappingId()
        {
            FbbTblMappingValidates = new HashSet<FbbTblMappingValidate>();
        }

        public int Id { get; set; }
        public string TypeEvent { get; set; } = null!;
        public string AppSoucre { get; set; } = null!;
        public string ResponseTime { get; set; } = null!;
        public string? Created { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? LastUpd { get; set; }
        public DateTime? LastUpdDate { get; set; }

        public virtual ICollection<FbbTblMappingValidate> FbbTblMappingValidates { get; set; }
    }
}
