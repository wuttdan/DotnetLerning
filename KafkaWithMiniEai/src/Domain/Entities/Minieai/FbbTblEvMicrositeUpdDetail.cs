using System;
using System.Collections.Generic;

namespace Domain.Entities.Minieai
{
    public partial class FbbTblEvMicrositeUpdDetail
    {
        public long Id { get; set; }
        public long HeaderId { get; set; }
        public string? OrderChannel { get; set; }
        public string? IsContactCustomer { get; set; }
        public string? IsInCoverage { get; set; }
        public string? UserAction { get; set; }
        public string? DateAction { get; set; }
        public string? OrderPreRegister { get; set; }
        public string? StatusOrder { get; set; }
        public string? RemarkNote { get; set; }
        public string? Created { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? LastUpd { get; set; }
        public DateTime? LastUpdDate { get; set; }

        public virtual FbbTblEvMicrositeUpdHeader Header { get; set; } = null!;
    }
}
