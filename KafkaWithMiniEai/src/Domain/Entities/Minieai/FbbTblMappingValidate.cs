namespace Domain.Entities.Minieai
{
    public partial class FbbTblMappingValidate
    {
        public int Id { get; set; }
        public int? MappingId { get; set; }
        public string? AppSoucre { get; set; }
        public string? ParameterXml { get; set; }
        public string? ConstraintValidate { get; set; }
        public string? ActiveFlag { get; set; }

        public virtual FbbTblMappingId? Mapping { get; set; }
    }
}
