namespace Domain.Entities.Minieai
{
    public partial class FbbTblMappingExternal
    {
        public int Id { get; set; }
        public int MappingWo { get; set; }
        public string? ExternalId { get; set; }
        public string? Typews { get; set; }
        public string? EndpointName { get; set; }
        public string? UrlEndpoint { get; set; }
        public string? IsOnline { get; set; }
        public int? RetryCount { get; set; }
        public int? SleepTimes { get; set; }
        public string? Created { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? LastUpd { get; set; }
        public DateTime? LastUpdDate { get; set; }
        public int? RequestTimeout { get; set; }

        public virtual FbbTblMappingWo MappingWoNavigation { get; set; } = null!;
    }
}
