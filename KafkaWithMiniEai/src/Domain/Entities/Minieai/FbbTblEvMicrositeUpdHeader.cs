namespace Domain.Entities.Minieai
{
    public partial class FbbTblEvMicrositeUpdHeader
    {
        public FbbTblEvMicrositeUpdHeader()
        {
            FbbTblEvmicrositeupdDetails = new HashSet<FbbTblEvMicrositeUpdDetail>();
        }

        public long Id { get; set; }
        public string? TransactionId { get; set; }
        public string? OrderNo { get; set; }
        public string? Status { get; set; }
        public string? Created { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? LastUpd { get; set; }
        public DateTime? LastUpdDate { get; set; }
        public string? ServerName { get; set; }

        public virtual ICollection<FbbTblEvMicrositeUpdDetail> FbbTblEvmicrositeupdDetails { get; set; }
    }
}
