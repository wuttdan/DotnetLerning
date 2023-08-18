using MediatR;

namespace Application.Query.AutoApprove;

public sealed class WorkorderAutoApproveHandler : IRequestHandler<WorkorderAutoApproveRequestModel, WorkorderAutoApproveResponseModel>
{
    public Task<WorkorderAutoApproveResponseModel> Handle(WorkorderAutoApproveRequestModel request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
