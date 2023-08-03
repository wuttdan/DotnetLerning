using MediatR;

namespace Application.Query.Authorization;

public class AuthorizationHandler : IRequestHandler<AuthorizationRequestModel, AuthorizationResponseModel>
{
    public Task<AuthorizationResponseModel> Handle(AuthorizationRequestModel request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
