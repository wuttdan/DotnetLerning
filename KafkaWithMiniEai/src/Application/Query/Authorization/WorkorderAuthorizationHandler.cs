using MediatR;

namespace Application.Query.Authorization;

public sealed class WorkorderAuthorizationHandler : IRequestHandler<WorkorderAuthorizationRequestModel, WorkorderAuthorizationResponseModel>
{
    public Task<WorkorderAuthorizationResponseModel> Handle(WorkorderAuthorizationRequestModel request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
