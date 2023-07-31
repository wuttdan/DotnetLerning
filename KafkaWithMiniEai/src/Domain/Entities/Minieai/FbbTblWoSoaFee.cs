using System;
using System.Collections.Generic;

namespace Domain.Entities.Minieai
{
    public partial class FbbTblWoSoaFee
    {
        public long Id { get; set; }
        public long? WoId { get; set; }
        public int? Group { get; set; }
        public string? Data { get; set; }
        public string? Created { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? LastUpd { get; set; }
        public DateTime? LastUpdDate { get; set; }

        public virtual FbbTblWo? Wo { get; set; }
    }
}
