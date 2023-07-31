using System;
using System.Collections.Generic;

namespace Domain.Entities.Minieai
{
    public partial class FbbTblListOfValue
    {
        public int Id { get; set; }
        public string LovName { get; set; } = null!;
        public string? LovValue1 { get; set; }
        public string? LovValue2 { get; set; }
        public string? LovValue3 { get; set; }
        public string ActiveFlag { get; set; } = null!;
        public string? ExternalId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Created { get; set; }
        public DateTime? LastUpdDate { get; set; }
        public string? LastUpd { get; set; }
    }
}
