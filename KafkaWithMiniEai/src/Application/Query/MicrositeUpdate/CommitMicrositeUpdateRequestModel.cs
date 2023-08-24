using Application.Common.Models.Microsite;
using Application.Query.SendCheckInLate;
using MediatR;

namespace Application.Query.Microsite;

public sealed class CommitMicrositeUpdateRequestModel : MicrositeUpdateRequestBase, IRequest<CommitMicrositeUpdateResponseModel>
{
    public override CommitMicrositeUpdateResponseModel CreateResponse(string resultDesc = "", string resultCode = "")
    {
        return new()
        {
            TRANSACTION_ID = TransactionId,
            RESULT_CODE = resultCode,
            RESULT_DESC = resultDesc
        };
    }
}
