using Application.Common.Core;
using MediatR;

namespace Application.Query.Microsite;

public class MicrositeRequestModel : RequestBase, IRequest<MicrositeResponseModel>
{
}
