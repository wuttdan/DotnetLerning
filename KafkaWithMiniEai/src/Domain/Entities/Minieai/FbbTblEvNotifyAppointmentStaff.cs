namespace Domain.Entities.Minieai
{
    public partial class FbbTblEvNotifyAppointmentStaff
    {
        public long Id { get; set; }
        public long HeaderId { get; set; }
        public int? Group { get; set; }
        public string? StaffCode { get; set; }
        public string? StaffName { get; set; }
        public string? StaffPhone { get; set; }
        public string? StaffEmail { get; set; }
        public string? StaffLatitude { get; set; }
        public string? StaffLongitude { get; set; }
        public string? StaffFirstDayWorking { get; set; }
        public string? StaffEndDayWorking { get; set; }
        public string? StaffRole { get; set; }
        public string? StaffProfilePictureFilename { get; set; }
        public string? Created { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? LastUpd { get; set; }
        public DateTime? LastUpdDate { get; set; }

        public virtual FbbTblEvNotifyAppointmentHeader Header { get; set; } = null!;
    }
}
