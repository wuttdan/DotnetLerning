using Domain.Common.Core;

namespace Application.Common.Models.NotifyAppointmentOrder;

public abstract class NotifyAppointmentOrderSubcontractRemark : BracketModel
{
    public string? AUTHOR { get; set; }
    public string? SUBCONTRACT_REMARKS { get; set; }
    public string? REMARK_DATE { get; set; }
}

public sealed class NotifyAppointmentOrderCrm : NotifyAppointmentOrderSubcontractRemark
{
}

public sealed class NotifyAppointmentOrderWfm : NotifyAppointmentOrderSubcontractRemark
{
}