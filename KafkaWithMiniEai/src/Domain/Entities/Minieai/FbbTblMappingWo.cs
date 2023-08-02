namespace Domain.Entities.Minieai
{
    public partial class FbbTblMappingWo
    {
        public FbbTblMappingWo()
        {
            FbbTblMappingExternals = new HashSet<FbbTblMappingExternal>();
            FbbTblMappingParameters = new HashSet<FbbTblMappingParameter>();
        }

        public int Id { get; set; }
        public int MappingId { get; set; }
        public string? Destination { get; set; }
        public string? ExternalId { get; set; }
        public string? TypeExternal { get; set; }
        public int? SeqNum { get; set; }
        public string? Created { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? LastUpd { get; set; }
        public DateTime? LastUpdDate { get; set; }

        public virtual ICollection<FbbTblMappingExternal> FbbTblMappingExternals { get; set; }
        public virtual ICollection<FbbTblMappingParameter> FbbTblMappingParameters { get; set; }
    }
}
