using MediatR;

namespace Application.Query.Authorization;

public sealed class CommitAuthorizationHandler : IRequestHandler<CommitAuthorizationRequestModel, CommonAuthorizationResponseModel>
{
    public Task<CommonAuthorizationResponseModel> Handle(CommitAuthorizationRequestModel request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
