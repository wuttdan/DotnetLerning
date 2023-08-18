using Application.Common.Models.AutoApprove;
using MediatR;

namespace Application.Query.AutoApprove;

public sealed class CommitAutoApproveHandler : IRequestHandler<CommitAutoApproveRequestModel, CommitAutoApproveResponseModel>
{
    public Task<CommitAutoApproveResponseModel> Handle(CommitAutoApproveRequestModel request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
