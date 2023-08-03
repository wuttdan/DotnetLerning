using MediatR;

namespace Application.Query.SendCheckInLate;

public class SendCheckInLateHandler : IRequestHandler<SendCheckInLateRequestModel, SendCheckInLateResponseModel>
{
    public Task<SendCheckInLateResponseModel> Handle(SendCheckInLateRequestModel request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
