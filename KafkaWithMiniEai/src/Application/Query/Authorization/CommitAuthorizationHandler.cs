using MediatR;

namespace Application.Query.Authorization;

public sealed class CommitAuthorizationHandler : IRequestHandler<CommitAuthorizationRequestModel, CommitAuthorizationResponseModel>
{
    public Task<CommitAuthorizationResponseModel> Handle(CommitAuthorizationRequestModel request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
