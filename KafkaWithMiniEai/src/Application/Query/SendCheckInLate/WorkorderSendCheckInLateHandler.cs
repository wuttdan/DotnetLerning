using MediatR;

namespace Application.Query.SendCheckInLate;

public sealed class WorkorderSendCheckInLateHandler : IRequestHandler<WorkorderSendCheckInLateRequestModel, WorkorderSendCheckInLateResponseModel>
{
    public Task<WorkorderSendCheckInLateResponseModel> Handle(WorkorderSendCheckInLateRequestModel request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}

