using MediatR;

namespace Application.Query.JobIncomplete;

public sealed class DecomposeJobIncompleteHandler : IRequestHandler<DecomposeJobIncompleteRequestModel, DecomposeJobIncompleteResponseModel>
{
    public Task<DecomposeJobIncompleteResponseModel> Handle(DecomposeJobIncompleteRequestModel request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
