using MediatR;

namespace Application.Query.Authorization;

public sealed class DecomposeAuthorizationHandler : IRequestHandler<DecomposeAuthorizationRequestModel, DecomposeAuthorizationResponseModel>
{
    public Task<DecomposeAuthorizationResponseModel> Handle(DecomposeAuthorizationRequestModel request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
