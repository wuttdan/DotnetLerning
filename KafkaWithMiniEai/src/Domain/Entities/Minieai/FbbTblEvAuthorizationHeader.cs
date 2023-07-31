using System;
using System.Collections.Generic;

namespace Domain.Entities.Minieai;

public partial class FbbTblEvAuthorizationHeader
{
    public FbbTblEvAuthorizationHeader()
    {
        FbbTblEvauthorizationDetails = new HashSet<FbbTblEvAuthorizationDetail>();
    }

    public long Id { get; set; }
    public string? TransactionId { get; set; }
    public string? AcimVersion { get; set; }
    public string? AcimAppname { get; set; }
    public string? AcimClientId { get; set; }
    public string? Action { get; set; }
    public string? Status { get; set; }
    public string? Created { get; set; }
    public DateTime? CreatedDate { get; set; }
    public string? LastUpd { get; set; }
    public DateTime? LastUpdDate { get; set; }
    public string? ServerName { get; set; }

    public virtual ICollection<FbbTblEvAuthorizationDetail> FbbTblEvauthorizationDetails { get; set; }
}
