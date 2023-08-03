using MediatR;

namespace Application.Query.AutoApprove;

public class AutoApproveHandler : IRequestHandler<AutoApproveRequestModel, AutoApproveResponseModel>
{
    public Task<AutoApproveResponseModel> Handle(AutoApproveRequestModel request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
