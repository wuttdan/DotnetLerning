namespace Domain.Entities.Minieai
{
    public partial class FbbTblWo
    {
        public FbbTblWo()
        {
            FbbTblWoAttributes = new HashSet<FbbTblWoAttribute>();
            FbbTblWoBlames = new HashSet<FbbTblWoBlame>();
            FbbTblWoErrorMessages = new HashSet<FbbTblWoErrorMessage>();
            FbbTblWoSoaCompanies = new HashSet<FbbTblWoSoaCompany>();
            FbbTblWoSoaCrms = new HashSet<FbbTblWoSoaCrm>();
            FbbTblWoSoaFees = new HashSet<FbbTblWoSoaFee>();
            FbbTblWoSoaHeaders = new HashSet<FbbTblWoSoaHeader>();
            FbbTblWoSoaInstallOrders = new HashSet<FbbTblWoSoaInstallOrder>();
            FbbTblWoSoaMaOrders = new HashSet<FbbTblWoSoaMaOrder>();
            FbbTblWoSoaOntops = new HashSet<FbbTblWoSoaOntop>();
            FbbTblWoSoaResources = new HashSet<FbbTblWoSoaResource>();
            FbbTblWoSoaStaffs = new HashSet<FbbTblWoSoaStaff>();
            FbbTblWoSoaTeams = new HashSet<FbbTblWoSoaTeam>();
            FbbTblWoSoaWfms = new HashSet<FbbTblWoSoaWfm>();
        }

        public long Id { get; set; }
        public string? OrderNo { get; set; }
        public string? TransactionId { get; set; }
        public string? Destination { get; set; }
        public string? ExternalId { get; set; }
        public string? Status { get; set; }
        public DateTime? RequestDate { get; set; }
        public DateTime? ResponseDate { get; set; }
        public int RetryNo { get; set; }
        public string? Created { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? LastUpd { get; set; }
        public DateTime? LastUpdDate { get; set; }

        public virtual ICollection<FbbTblWoAttribute> FbbTblWoAttributes { get; set; }
        public virtual ICollection<FbbTblWoBlame> FbbTblWoBlames { get; set; }
        public virtual ICollection<FbbTblWoErrorMessage> FbbTblWoErrorMessages { get; set; }
        public virtual ICollection<FbbTblWoSoaCompany> FbbTblWoSoaCompanies { get; set; }
        public virtual ICollection<FbbTblWoSoaCrm> FbbTblWoSoaCrms { get; set; }
        public virtual ICollection<FbbTblWoSoaFee> FbbTblWoSoaFees { get; set; }
        public virtual ICollection<FbbTblWoSoaHeader> FbbTblWoSoaHeaders { get; set; }
        public virtual ICollection<FbbTblWoSoaInstallOrder> FbbTblWoSoaInstallOrders { get; set; }
        public virtual ICollection<FbbTblWoSoaMaOrder> FbbTblWoSoaMaOrders { get; set; }
        public virtual ICollection<FbbTblWoSoaOntop> FbbTblWoSoaOntops { get; set; }
        public virtual ICollection<FbbTblWoSoaResource> FbbTblWoSoaResources { get; set; }
        public virtual ICollection<FbbTblWoSoaStaff> FbbTblWoSoaStaffs { get; set; }
        public virtual ICollection<FbbTblWoSoaTeam> FbbTblWoSoaTeams { get; set; }
        public virtual ICollection<FbbTblWoSoaWfm> FbbTblWoSoaWfms { get; set; }
    }
}
