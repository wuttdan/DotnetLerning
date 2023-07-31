using System;
using System.Collections.Generic;

namespace Domain.Entities.Minieai
{
    public partial class FbbTblEvNotifyAppointmentResource
    {
        public long Id { get; set; }
        public long OrderId { get; set; }
        public string? Service { get; set; }
        public string? DownlinkRate { get; set; }
        public string? UplinkRate { get; set; }
        public string? Password { get; set; }
        public string? CpeModel { get; set; }
        public string? SplitterPort { get; set; }
        public string? SplitterNamePrimary { get; set; }
        public string? OltName { get; set; }
        public string? ActivationId { get; set; }
        public string? CpeSn { get; set; }
        public string? Cvlan { get; set; }
        public string? DeviceModel { get; set; }
        public string? DslamManufacturer { get; set; }
        public string? DslamPort { get; set; }
        public string? MdfOutPort { get; set; }
        public string? OdfFiberCore { get; set; }
        public string? Sp1FiberCore { get; set; }
        public string? Gemport { get; set; }
        public string? StandardAddressName { get; set; }
        public string? IpAddress { get; set; }
        public string? Sp1Latitude { get; set; }
        public string? Sp1Longitude { get; set; }
        public string? Sp2Latitude { get; set; }
        public string? Sp2Longitude { get; set; }
        public string? OdfIn { get; set; }
        public string? OdfOut { get; set; }
        public string? OltManufacturer { get; set; }
        public string? OltPonPort { get; set; }
        public string? Onu { get; set; }
        public string? OnuId { get; set; }
        public string? OnuModel { get; set; }
        public string? OnuUplinkPort { get; set; }
        public string? Sp1RunningState { get; set; }
        public string? Sp2RunningState { get; set; }
        public string? SplitterDistance { get; set; }
        public string? Sp1InPort { get; set; }
        public string? Sp2InPort { get; set; }
        public string? Sp1OutPort { get; set; }
        public string? Sp2OutPort { get; set; }
        public string? Svlan { get; set; }
        public string? Tcont { get; set; }
        public string? Sp2Distance { get; set; }
        public string? DropWireDistance { get; set; }
        public string? ExistingDropWireId { get; set; }
        public string? EndPointLatitude { get; set; }
        public string? EndPointLongitude { get; set; }
        public string? NewDropWireId { get; set; }
        public string? ReuseFlag { get; set; }
        public string? CpeInstallation { get; set; }
        public string? Created { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? LastUpd { get; set; }
        public DateTime? LastUpdDate { get; set; }

        public virtual FbbTblEvNotifyAppointmentOrder Order { get; set; } = null!;
    }
}
