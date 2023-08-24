using Application.Common.Models.NotifyAppointmentOrder;
using Application.Query.SendCheckInLate;
using MediatR;

namespace Application.Query.NotifyAppointmentOrder;

public sealed class CommitNotifyAppointmentOrderRequestModel : NotifyAppointmentOrderRequestBase, IRequest<CommitNotifyAppointmentOrderResponseModel>
{
    public override CommitNotifyAppointmentOrderResponseModel CreateResponse(string resultDesc = "", string resultCode = "")
    {
        return new()
        {
            TRANSACTION_ID = TransactionId,
            TYPE = TYPE,
            FIBRENET_ID = FIBRENET_ID,
            RESULT_CODE = resultCode,
            RESULT_DESC = resultDesc
        };
    }
}
