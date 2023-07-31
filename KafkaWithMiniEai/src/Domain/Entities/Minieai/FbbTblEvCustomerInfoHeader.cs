using System;
using System.Collections.Generic;

namespace Domain.Entities.Minieai;

public partial class FbbTblEvCustomerInfoHeader
{
    public FbbTblEvCustomerInfoHeader()
    {
        FbbTblEvcustomerinfoDetails = new HashSet<FbbTblEvCustomerInfoDetail>();
    }

    public long Id { get; set; }
    public string? TransactionId { get; set; }
    public string? InternetId { get; set; }
    public string? OrderNo { get; set; }
    public string? Status { get; set; }
    public string? Created { get; set; }
    public DateTime? CreatedDate { get; set; }
    public string? LastUpd { get; set; }
    public DateTime? LastUpdDate { get; set; }
    public string? ServerName { get; set; }

    public virtual ICollection<FbbTblEvCustomerInfoDetail> FbbTblEvcustomerinfoDetails { get; set; }
}
