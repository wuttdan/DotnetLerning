using MediatR;

namespace Application.Query.JobIncomplete;

public sealed class WorkorderJobIncompleteHandler : IRequestHandler<WorkorderJobIncompleteRequestModel, WorkorderJobIncompleteResponseModel>
{
    public Task<WorkorderJobIncompleteResponseModel> Handle(WorkorderJobIncompleteRequestModel request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
