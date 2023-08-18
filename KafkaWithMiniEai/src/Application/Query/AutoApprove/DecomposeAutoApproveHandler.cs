using MediatR;

namespace Application.Query.AutoApprove;

public sealed class DecomposeAutoApproveHandler : IRequestHandler<DecomposeAutoApproveRequestModel, DecomposeAutoApproveResponseModel>
{
    public Task<DecomposeAutoApproveResponseModel> Handle(DecomposeAutoApproveRequestModel request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
