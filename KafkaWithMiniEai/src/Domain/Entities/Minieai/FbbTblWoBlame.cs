using System;
using System.Collections.Generic;

namespace Domain.Entities.Minieai
{
    public partial class FbbTblWoBlame
    {
        public long Id { get; set; }
        public long? WoId { get; set; }
        public string? FieldPath { get; set; }
        public string? ValueBefore { get; set; }
        public string? ValueAfter { get; set; }
        public string? Created { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? LastUpd { get; set; }
        public DateTime? LastUpdDate { get; set; }

        public virtual FbbTblWo? Wo { get; set; }
    }
}
