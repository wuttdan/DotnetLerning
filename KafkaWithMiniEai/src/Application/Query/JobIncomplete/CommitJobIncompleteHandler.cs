using MediatR;

namespace Application.Query.JobIncomplete;

public sealed class CommitJobIncompleteHandler : IRequestHandler<CommitJobIncompleteRequestModel, CommitJobIncompleteResponseModel>
{
    public Task<CommitJobIncompleteResponseModel> Handle(CommitJobIncompleteRequestModel request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
