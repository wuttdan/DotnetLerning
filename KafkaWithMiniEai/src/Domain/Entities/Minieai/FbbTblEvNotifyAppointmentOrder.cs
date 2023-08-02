namespace Domain.Entities.Minieai
{
    public partial class FbbTblEvNotifyAppointmentOrder
    {
        public FbbTblEvNotifyAppointmentOrder()
        {
            FbbTblEvnotifyappointmentCrms = new HashSet<FbbTblEvNotifyAppointmentCrm>();
            FbbTblEvnotifyappointmentFees = new HashSet<FbbTblEvNotifyAppointmentFee>();
            FbbTblEvnotifyappointmentOntops = new HashSet<FbbTblEvNotifyAppointmentOntop>();
            FbbTblEvnotifyappointmentResources = new HashSet<FbbTblEvNotifyAppointmentResource>();
            FbbTblEvnotifyappointmentWfms = new HashSet<FbbTblEvNotifyAppointmentWfm>();
        }

        public long Id { get; set; }
        public long HeaderId { get; set; }
        public string? CustomerOrderNo { get; set; }
        public string? FbssOrderNo { get; set; }
        public string? TaskOrderNo { get; set; }
        public string? TroubleTicketNo { get; set; }
        public string? SiebelRequestNo { get; set; }
        public string? FibrenetId { get; set; }
        public string? JobState { get; set; }
        public string? JobPriority { get; set; }
        public string? ProductName { get; set; }
        public string? AccessMode { get; set; }
        public string? Service { get; set; }
        public string? DownlinkRate { get; set; }
        public string? UplinkRate { get; set; }
        public string? CommitDate { get; set; }
        public string? AcceptDate { get; set; }
        public string? TroubleSymptom { get; set; }
        public string? ComplaintTitle { get; set; }
        public string? CustomerComplaintName { get; set; }
        public string? CustomerComplaintMobile { get; set; }
        public string? NocRemark { get; set; }
        public string? NocNumber { get; set; }
        public string? DetailsForResolved { get; set; }
        public string? ComplaintDescription { get; set; }
        public string? OrderType { get; set; }
        public string? ReplaceOntFlag { get; set; }
        public string? ReplaceRouterFlag { get; set; }
        public string? RouterNum { get; set; }
        public string? CustomerName { get; set; }
        public string? ContactPersonName { get; set; }
        public string? ContactMobilePhone1 { get; set; }
        public string? ContactMobilePhone2 { get; set; }
        public string? ContactMobilePhone3 { get; set; }
        public string? InstallationAddress { get; set; }
        public string? InstallationLatitude { get; set; }
        public string? InstallationLongitude { get; set; }
        public string? Brand { get; set; }
        public string? EventflowFlag { get; set; }
        public string? ServiceLevel { get; set; }
        public string? OntopPack { get; set; }
        public string? ServicePack { get; set; }
        public string? VoipNumber1 { get; set; }
        public string? VoipPassword1 { get; set; }
        public string? VoipNumber2 { get; set; }
        public string? VoipPassword2 { get; set; }
        public string? PlayboxContent { get; set; }
        public string? TotalFee { get; set; }
        public string? AppointmentDate { get; set; }
        public string? AppointmentTimeslot { get; set; }
        public string? Created { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? LastUpd { get; set; }
        public DateTime? LastUpdDate { get; set; }

        public virtual FbbTblEvNotifyAppointmentHeader Header { get; set; } = null!;
        public virtual ICollection<FbbTblEvNotifyAppointmentCrm> FbbTblEvnotifyappointmentCrms { get; set; }
        public virtual ICollection<FbbTblEvNotifyAppointmentFee> FbbTblEvnotifyappointmentFees { get; set; }
        public virtual ICollection<FbbTblEvNotifyAppointmentOntop> FbbTblEvnotifyappointmentOntops { get; set; }
        public virtual ICollection<FbbTblEvNotifyAppointmentResource> FbbTblEvnotifyappointmentResources { get; set; }
        public virtual ICollection<FbbTblEvNotifyAppointmentWfm> FbbTblEvnotifyappointmentWfms { get; set; }
    }
}
