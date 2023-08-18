using Application.Common.Models.SendCheckInLate;
using MediatR;

namespace Application.Query.SendCheckInLate;

public sealed class CommitSendCheckInLateHandler : IRequestHandler<CommitSendCheckInLateRequestModel, CommitSendCheckInLateResponseModel>
{
    public Task<CommitSendCheckInLateResponseModel> Handle(CommitSendCheckInLateRequestModel request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}

