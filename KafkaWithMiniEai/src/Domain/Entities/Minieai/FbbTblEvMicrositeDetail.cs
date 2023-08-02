namespace Domain.Entities.Minieai
{
    public partial class FbbTblEvMicrositeDetail
    {
        public long Id { get; set; }
        public long HeaderId { get; set; }
        public string? User { get; set; }
        public string? Segment { get; set; }
        public string? NumberOfUser { get; set; }
        public string? Residential { get; set; }
        public string? TypeOfUser { get; set; }
        public string? Package { get; set; }
        public string? PackageCode { get; set; }
        public string? Speed { get; set; }
        public string? PlayboxBundle { get; set; }
        public string? PlayboxAddon { get; set; }
        public string? RouterBundle { get; set; }
        public string? RouterAddon { get; set; }
        public string? Price { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public string? Telephone { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? Subdistrict { get; set; }
        public string? District { get; set; }
        public string? Province { get; set; }
        public string? Zipcode { get; set; }
        public string? MediaStreaming { get; set; }
        public string? UserJourney { get; set; }
        public string? Cid { get; set; }
        public string? Complete { get; set; }
        public string? Created { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? LastUpd { get; set; }
        public DateTime? LastUpdDate { get; set; }

        public virtual FbbTblEvMicrositeHeader Header { get; set; } = null!;
    }
}
