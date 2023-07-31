using System;
using System.Collections.Generic;

namespace Domain.Entities.Minieai
{
    public partial class FbbTblEvNotifyAppointmentCrm
    {
        public long Id { get; set; }
        public long OrderId { get; set; }
        public int? Group { get; set; }
        public string? Author { get; set; }
        public string? SubcontractRemarks { get; set; }
        public string? RemarkDate { get; set; }
        public string? Created { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? LastUpd { get; set; }
        public DateTime? LastUpdDate { get; set; }

        public virtual FbbTblEvNotifyAppointmentOrder Order { get; set; } = null!;
    }
}
