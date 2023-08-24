using Application.Common.Core;
using Application.Common.Models.SendCheckInLate;
using MediatR;

namespace Application.Query.SendCheckInLate;

public sealed class CommitSendCheckInLateRequestModel : SendCheckInLateRequestBase, IRequest<CommitSendCheckInLateResponseModel>
{
    public override CommitSendCheckInLateResponseModel CreateResponse(string resultDesc = "", string resultCode = "")
    {
        return new ()
        {
            TRANSACTION_ID = TransactionId,
            RESULT_CODE = resultCode,
            RESULT_DESC = resultDesc
        };
    }
}
