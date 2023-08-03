using Application.Common.Core;
using MediatR;

namespace Application.Query.JobIncomplete;

public class JobIncompleteRequestModel : RequestBase, IRequest<JobIncompleteResponseModel>
{
}
