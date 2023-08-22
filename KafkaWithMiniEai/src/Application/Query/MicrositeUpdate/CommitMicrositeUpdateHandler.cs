using MediatR;

namespace Application.Query.Microsite;

public sealed class CommitMicrositeUpdateHandler : IRequestHandler<CommitMicrositeUpdateRequestModel, CommitMicrositeUpdateResponseModel>
{
    public Task<CommitMicrositeUpdateResponseModel> Handle(CommitMicrositeUpdateRequestModel request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}


