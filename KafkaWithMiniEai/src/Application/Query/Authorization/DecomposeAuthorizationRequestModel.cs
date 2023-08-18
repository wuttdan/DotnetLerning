using Application.Common.Models.Authorization;
using MediatR;

namespace Application.Query.Authorization;

public sealed class DecomposeAuthorizationRequestModel : AuthorizationRequestBase, IRequest<DecomposeAuthorizationResponseModel>
{
}
