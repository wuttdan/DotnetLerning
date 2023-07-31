using System;
using System.Collections.Generic;

namespace Domain.Entities.Minieai
{
    public partial class FbbTblWoSoaTeam
    {
        public long Id { get; set; }
        public long WoId { get; set; }
        public long? CompanyId { get; set; }
        public int? Group { get; set; }
        public string? TeamName { get; set; }
        public string? TeamId { get; set; }
        public string? TeamService { get; set; }
        public string? VendorCode { get; set; }
        public string? LocationCode { get; set; }
        public string? StorageLocation { get; set; }
        public string? ShipTo { get; set; }
        public string? Created { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? LastUpd { get; set; }
        public DateTime? LastUpdDate { get; set; }

        public virtual FbbTblWo Wo { get; set; } = null!;
    }
}
