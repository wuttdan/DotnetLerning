using Application.Common.Models.Microsite;
using MediatR;

namespace Application.Query.Microsite;

public sealed class DecomposeMicrositeUpdateRequestModel : MicrositeUpdateRequestBase, IRequest<DecomposeMicrositeUpdateResponseModel>
{
}
