using Application.Query.JobApprove;
using FluentValidation;

namespace Application.Query.JobIncomplete;

public sealed class CommitJobIncompleteValidator : AbstractValidator<CommitJobIncompleteRequestModel>
{
}
