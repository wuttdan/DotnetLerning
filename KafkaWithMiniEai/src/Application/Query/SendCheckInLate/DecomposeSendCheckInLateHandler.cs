using MediatR;

namespace Application.Query.SendCheckInLate;

public sealed class DecomposeSendCheckInLateHandler : IRequestHandler<DecomposeSendCheckInLateRequestModel, DecomposeSendCheckInLateResponseModel>
{
    public Task<DecomposeSendCheckInLateResponseModel> Handle(DecomposeSendCheckInLateRequestModel request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}

