using Application.Common.Models.Authorization;
using FluentValidation;

namespace Application.Query.Authorization;

public sealed class CommitAuthorizationValidator : AbstractValidator<CommitAuthorizationRequestModel>
{
}
