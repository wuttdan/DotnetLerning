using System;
using System.Collections.Generic;

namespace Domain.Entities.Minieai
{
    public partial class FbbTblEvNotifyAppointmentHeader
    {
        public FbbTblEvNotifyAppointmentHeader()
        {
            FbbTblEvnotifyappointmentCompanies = new HashSet<FbbTblEvNotifyAppointmentCompany>();
            FbbTblEvnotifyappointmentOrders = new HashSet<FbbTblEvNotifyAppointmentOrder>();
            FbbTblEvnotifyappointmentStaffs = new HashSet<FbbTblEvNotifyAppointmentStaff>();
            FbbTblEvnotifyappointmentTeams = new HashSet<FbbTblEvNotifyAppointmentTeam>();
        }

        public long Id { get; set; }
        public string? TransactionId { get; set; }
        public string? FibrenetId { get; set; }
        public string? Type { get; set; }
        public string? OrderType { get; set; }
        public string? TypeOperDate { get; set; }
        public string? MsgSeqId { get; set; }
        public string? Status { get; set; }
        public string? Created { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? LastUpd { get; set; }
        public DateTime? LastUpdDate { get; set; }
        public string? ServerName { get; set; }

        public virtual ICollection<FbbTblEvNotifyAppointmentCompany> FbbTblEvnotifyappointmentCompanies { get; set; }
        public virtual ICollection<FbbTblEvNotifyAppointmentOrder> FbbTblEvnotifyappointmentOrders { get; set; }
        public virtual ICollection<FbbTblEvNotifyAppointmentStaff> FbbTblEvnotifyappointmentStaffs { get; set; }
        public virtual ICollection<FbbTblEvNotifyAppointmentTeam> FbbTblEvnotifyappointmentTeams { get; set; }
    }
}
