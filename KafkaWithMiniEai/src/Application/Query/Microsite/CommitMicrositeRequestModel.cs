using Application.Common.Models.Microsite;
using MediatR;

namespace Application.Query.Microsite;

public sealed class CommitMicrositeRequestModel : MicrositeRequestBase, IRequest<CommitMicrositeResponseModel>
{
    public override CommitMicrositeResponseModel CreateResponse(string resultDesc = "", string resultCode = "")
    {
        return new()
        {
            TRANSACTION_ID = TransactionId,
            RESULT_CODE = resultCode,
            RESULT_DESC = resultDesc
        };
    }
}
