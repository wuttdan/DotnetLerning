using MediatR;

namespace Application.Query.JobApprove;

public sealed class WorkorderJobApproveHandler : IRequestHandler<WorkorderJobApproveRequestModel, WorkorderJobApproveResponseModel>
{
    public Task<WorkorderJobApproveResponseModel> Handle(WorkorderJobApproveRequestModel request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
