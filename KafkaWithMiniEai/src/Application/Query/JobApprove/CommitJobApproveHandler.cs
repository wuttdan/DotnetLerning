using MediatR;

namespace Application.Query.JobApprove;

public sealed class CommitJobApproveHandler : IRequestHandler<CommitJobApproveRequestModel, CommitJobApproveResponseModel>
{
    public Task<CommitJobApproveResponseModel> Handle(CommitJobApproveRequestModel request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
