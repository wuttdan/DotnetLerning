using Application.Common.Core;
using Application.Extension;
using Application.Query.NotifyAppointmentOrder;
using FluentValidation;

namespace Application.Query;

public class CommonRequestHeaderValidator : AbstractValidator<RequestHeader>
{
    public CommonRequestHeaderValidator()
    {
        RuleFor(x => x.TransactionId)
            .NotNull().NotEmpty()
            .WithErrorCode("30000")
            .WithMessage(x => "Request header is incorrect, 'TRANSACTION-ID' is empty or null.");

        RuleFor(x => x.AppSource)
            .NotNull().NotEmpty()
            .WithErrorCode("30000")
            .WithMessage(x => "Request header is incorrect, 'AppSource' is empty or null.");

        RuleFor(x => x.AppDestination)
            .NotNull().NotEmpty()
            .WithErrorCode("30000")
            .WithMessage(x => "Request header is incorrect, 'AppDestination' is empty or null.");

        RuleFor(x => x.ContentType)
            .NotNull().NotEmpty()
            .WithErrorCode("30000")
            .WithMessage(x => "Request header is incorrect, 'Content-Type' is empty or null.");
    }
}