using System;
using System.Collections.Generic;

namespace Domain.Entities.Minieai
{
    public partial class FbbTblWoSoaMaOrder
    {
        public long Id { get; set; }
        public long WoId { get; set; }
        public string? TroubleTicketNo { get; set; }
        public string? SiebelRequestNo { get; set; }
        public string? TaskOrderNo { get; set; }
        public string? FibrenetId { get; set; }
        public string? JobState { get; set; }
        public string? JobPriority { get; set; }
        public string? ProductName { get; set; }
        public string? Service { get; set; }
        public string? AccessMode { get; set; }
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
        public string? CustomerName { get; set; }
        public string? ContactPersonName { get; set; }
        public string? ContactMobilePhone1 { get; set; }
        public string? ContactMobilePhone2 { get; set; }
        public string? ContactMobilePhone3 { get; set; }
        public string? AppointmentDate { get; set; }
        public string? AppointmentTimeslot { get; set; }
        public string? Created { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? LastUpd { get; set; }
        public DateTime? LastUpdDate { get; set; }
        public string? InstallationLatitude { get; set; }
        public string? InstallationLongitude { get; set; }
        public string? ServiceLevel { get; set; }
        public string? BuildingName { get; set; }
        public string? Area { get; set; }
        public string? Region { get; set; }
        public string? Address { get; set; }
        public string? CsNote { get; set; }
        public string? OntopPack { get; set; }
        public string? ServicePack { get; set; }
        public string? PlayboxContent { get; set; }

        public virtual FbbTblWo Wo { get; set; } = null!;
    }
}
