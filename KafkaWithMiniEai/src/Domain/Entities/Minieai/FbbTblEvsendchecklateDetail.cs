namespace Domain.Entities.Minieai
{
    public partial class FbbTblEvSendChecklateDetail
    {
        public long Id { get; set; }
        public long HeaderId { get; set; }
        public string? MnAppointmentDate { get; set; }
        public string? MnSlot { get; set; }
        public string? MnPackage { get; set; }
        public string? MnProductName { get; set; }
        public string? MnCustomerName { get; set; }
        public string? MnCustomerAddress { get; set; }
        public string? MnCustomerLatitude { get; set; }
        public string? MnCustomerLongitude { get; set; }
        public string? MnRegion { get; set; }
        public string? MnStaffCode { get; set; }
        public string? MnStaffName { get; set; }
        public string? MnStaffPhone { get; set; }
        public string? MnSubcontractTeam { get; set; }
        public string? MnCheckinLateTime { get; set; }
        public string? MnCheckinLateReason { get; set; }
        public string? MnCurrentLatitude { get; set; }
        public string? MnCurrentLongitude { get; set; }
        public string? MnCreateDate { get; set; }
        public string? MnCreatedBy { get; set; }
        public string? MnCustomerContact1 { get; set; }
        public string? MnCustomerContact2 { get; set; }
        public string? MnCustomerContact3 { get; set; }
        public string? MnRemarks { get; set; }
        public string? Refid { get; set; }
        public string? LateDuration { get; set; }
        public string? Created { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? LastUpd { get; set; }
        public DateTime? LastUpdDate { get; set; }

        public virtual FbbTblEvSendChecklateHeader Header { get; set; } = null!;
    }
}
