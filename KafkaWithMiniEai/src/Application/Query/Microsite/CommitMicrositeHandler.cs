using MediatR;

namespace Application.Query.Microsite;

public sealed class CommitMicrositeHandler : IRequestHandler<CommitMicrositeRequestModel, CommitMicrositeResponseModel>
{
    public Task<CommitMicrositeResponseModel> Handle(CommitMicrositeRequestModel request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}


