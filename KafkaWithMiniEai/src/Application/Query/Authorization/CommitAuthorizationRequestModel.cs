using Application.Common.Models.Authorization;
using MediatR;

namespace Application.Query.Authorization;

public sealed class CommitAuthorizationRequestModel : AuthorizationRequestBase, IRequest<CommitAuthorizationResponseModel>
{
}
