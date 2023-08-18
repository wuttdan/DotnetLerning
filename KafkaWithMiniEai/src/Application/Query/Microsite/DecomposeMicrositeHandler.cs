using MediatR;

namespace Application.Query.Microsite;

public sealed class DecomposeMicrositeHandler : IRequestHandler<DecomposeMicrositeRequestModel, DecomposeMicrositeResponseModel>
{
    public Task<DecomposeMicrositeResponseModel> Handle(DecomposeMicrositeRequestModel request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}


