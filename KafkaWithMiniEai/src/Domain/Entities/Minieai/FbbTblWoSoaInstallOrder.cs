using System;
using System.Collections.Generic;

namespace Domain.Entities.Minieai
{
    public partial class FbbTblWoSoaInstallOrder
    {
        public long Id { get; set; }
        public long? WoId { get; set; }
        public string? CustomerOrderNo { get; set; }
        public string? FbssOrderNo { get; set; }
        public string? TaskOrderNo { get; set; }
        public string? FibrenetId { get; set; }
        public string? JobState { get; set; }
        public string? JobPriority { get; set; }
        public string? ProductName { get; set; }
        public string? AccessMode { get; set; }
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
        public string? BuildingName { get; set; }
        public string? Area { get; set; }
        public string? Region { get; set; }
        public string? CsNote { get; set; }

        public virtual FbbTblWo? Wo { get; set; }
    }
}
