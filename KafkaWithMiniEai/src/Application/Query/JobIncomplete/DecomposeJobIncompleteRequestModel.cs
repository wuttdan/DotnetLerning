using Application.Common.Models.JobIncomplete;
using MediatR;

namespace Application.Query.JobIncomplete;

public sealed class DecomposeJobIncompleteRequestModel : JobIncompleteRequestBase, IRequest<DecomposeJobIncompleteResponseModel>
{
}
