using Application.Common.Core;

namespace Application.Common.Models.AutoApprove;

public class AutoApproveRequestBase : RequestBase
{
    private const string DefaulFormat = "dd/MM/yyyy HH:mm:ss";
    public string? TIMESTAMP { get; set; } = DateTime.Now.ToString(DefaulFormat);
}
