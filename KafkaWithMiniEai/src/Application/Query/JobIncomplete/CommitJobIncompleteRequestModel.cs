using Application.Common.Models.JobIncomplete;
using MediatR;

namespace Application.Query.JobIncomplete;

public sealed class CommitJobIncompleteRequestModel : JobIncompleteRequestBase, IRequest<CommitJobIncompleteResponseModel>
{
}
