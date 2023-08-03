using MediatR;

namespace Application.Query.JobIncomplete;

public class JobIncompleteHandler : IRequestHandler<JobIncompleteRequestModel, JobIncompleteResponseModel>
{
    public Task<JobIncompleteResponseModel> Handle(JobIncompleteRequestModel request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
