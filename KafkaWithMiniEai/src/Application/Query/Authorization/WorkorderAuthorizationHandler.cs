using MediatR;

namespace Application.Query.Authorization;

public sealed class WorkorderAuthorizationHandler : IRequestHandler<WorkorderAuthorizationRequestModel, CommonAuthorizationResponseModel>
{
    public Task<CommonAuthorizationResponseModel> Handle(WorkorderAuthorizationRequestModel request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
