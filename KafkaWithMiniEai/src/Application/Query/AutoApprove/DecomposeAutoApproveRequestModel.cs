using Application.Common.Models.AutoApprove;
using MediatR;

namespace Application.Query.AutoApprove;

public sealed class DecomposeAutoApproveRequestModel : AutoApproveRequestBase, IRequest<DecomposeAutoApproveResponseModel>
{
}



