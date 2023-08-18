using MediatR;

namespace Application.Query.JobApprove;

public sealed class DecomposeJobApproveHandler : IRequestHandler<DecomposeJobApproveRequestModel, DecomposeJobApproveResponseModel>
{
    public Task<DecomposeJobApproveResponseModel> Handle(DecomposeJobApproveRequestModel request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
