using Application.Common.Core;

namespace Application.Common.Models.JobIncomplete;

public class JobIncompleteRequestBase : RequestBase
{
    public string? internetNo { get; set; }
    public string? orderNo { get; set; }
    public string? reason { get; set; }
    public string? subReason { get; set; }
    public string? remark { get; set; }
    public string? attributeValue { get; set; }
    public string? attributeDesc { get; set; }
    public string? incompleteTime { get; set; }
}
