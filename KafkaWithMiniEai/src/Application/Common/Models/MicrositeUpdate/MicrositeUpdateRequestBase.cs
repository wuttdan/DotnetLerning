using Application.Common.Core;

namespace Application.Common.Models.Microsite;

public class MicrositeUpdateRequestBase : CommonRequestModel
{
    public string? ORDER_NO { get; set; }
    public string? ORDER_CHANNEL { get; set; }
    public string? IS_CONTACT_CUSTOMER { get; set; }
    public string? IS_IN_COVERAGE { get; set; }
    public string? USER_ACTION { get; set; }
    public string? DATE_ACTION { get; set; }
    public string? ORDER_PRE_REGISTER { get; set; }
    public string? STATUS_ORDER { get; set; }
    public string? REMARK_NOTE { get; set; }
}
