using Application.Common.Core;

namespace Application.Common.Models.JobApprove;

public class JobApproveRequestBase : RequestBase
{
    public string? internetNo { get; set; }
    public string? orderNo { get; set; }
    public string? approveTime { get; set; }
}
