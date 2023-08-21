namespace Domain.Entities.Minieai
{
    public partial class FbbTblEvSendChecklateHeader
    {
        public FbbTblEvSendChecklateHeader()
        {
            FbbTblEvsendchecklateDetails = new HashSet<FbbTblEvSendChecklateDetail>();
        }

        public long Id { get; set; }
        public string? TransactionId { get; set; }
        public string? InternetId { get; set; }
        public string? OrderNo { get; set; }
        public string? OrderType { get; set; }
        public string? Status { get; set; }
        public string? Created { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? LastUpd { get; set; }
        public DateTime? LastUpdDate { get; set; }
        public string? ServerName { get; set; }

        public virtual ICollection<FbbTblEvSendChecklateDetail> FbbTblEvsendchecklateDetails { get; set; }
    }
}
