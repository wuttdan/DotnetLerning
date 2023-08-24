using MediatR;

namespace Application.Query.Authorization;

public sealed class DecomposeAuthorizationHandler : IRequestHandler<DecomposeAuthorizationRequestModel, CommonAuthorizationResponseModel>
{
    public Task<CommonAuthorizationResponseModel> Handle(DecomposeAuthorizationRequestModel request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
