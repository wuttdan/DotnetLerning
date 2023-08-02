namespace Domain.Entities.Minieai
{
    public partial class FbbTblMappingParameter
    {
        public int Id { get; set; }
        public int MappingWo { get; set; }
        public string ExternalId { get; set; } = null!;
        public string ParamXmlName { get; set; } = null!;
        public string? SourceTable { get; set; }
        public string? DefaultValue { get; set; }
        public string? ColumnName { get; set; }
        public string? FieldNameValue { get; set; }
        public string? FormatValue { get; set; }
        public int? SeqNum { get; set; }
        public string? Created { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? LastUpd { get; set; }
        public DateTime? LastUpdDate { get; set; }

        public virtual FbbTblMappingWo MappingWoNavigation { get; set; } = null!;
    }
}
