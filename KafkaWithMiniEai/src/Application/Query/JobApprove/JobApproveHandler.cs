using MediatR;

namespace Application.Query.JobApprove;

public class JobApproveHandler : IRequestHandler<JobApproveRequestModel, JobApproveResponseModel>
{
    public Task<JobApproveResponseModel> Handle(JobApproveRequestModel request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
