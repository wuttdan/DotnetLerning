using System;
using System.Collections.Generic;

namespace Domain.Entities.Minieai
{
    public partial class FbbTblEvNotifyAppointmentCompany
    {
        public long Id { get; set; }
        public long HeaderId { get; set; }
        public long? StaffId { get; set; }
        public int? Group { get; set; }
        public string? CompanyName { get; set; }
        public string? CompanyId { get; set; }
        public string? VendorCode { get; set; }
        public string? LocationCode { get; set; }
        public string? StorageLocation { get; set; }
        public string? Created { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? LastUpd { get; set; }
        public DateTime? LastUpdDate { get; set; }

        public virtual FbbTblEvNotifyAppointmentHeader Header { get; set; } = null!;
    }
}
