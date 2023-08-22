using Application.Extension;
using FluentValidation;

namespace Application.Query.Microsite;

public sealed class CommitMicrositeValidator : AbstractValidator<CommitMicrositeRequestModel>
{
    public CommitMicrositeValidator()
    {
        RuleFor(x => x.USER)
            .NotNull().NotEmpty()
            .WithErrorCode("40001")
            .WithMessage(x => this.WithErrorMessage(nameof(x.USER)));

        RuleFor(x => x.SEGMENT)
            .NotNull().NotEmpty()
            .WithErrorCode("40002")
            .WithMessage(x => this.WithErrorMessage(nameof(x.SEGMENT)));

        RuleFor(x => x.NUMBER_OF_USER)
            .NotNull().NotEmpty()
            .WithErrorCode("40003")
            .WithMessage(x => this.WithErrorMessage(nameof(x.NUMBER_OF_USER)));

        RuleFor(x => x.RESIDENTIAL)
            .NotNull().NotEmpty()
            .WithErrorCode("40004")
            .WithMessage(x => this.WithErrorMessage(nameof(x.RESIDENTIAL)));

        RuleFor(x => x.TYPE_OF_USER)
            .NotNull().NotEmpty()
            .WithErrorCode("40005")
            .WithMessage(x => this.WithErrorMessage(nameof(x.TYPE_OF_USER)));

        RuleFor(x => x.PACKAGE)
            .NotNull().NotEmpty()
            .WithErrorCode("40006")
            .WithMessage(x => this.WithErrorMessage(nameof(x.PACKAGE)));

        RuleFor(x => x.PACKAGE_CODE)
            .NotNull().NotEmpty()
            .WithErrorCode("40007")
            .WithMessage(x => this.WithErrorMessage(nameof(x.PACKAGE_CODE)));

        RuleFor(x => x.SPEED)
            .NotNull().NotEmpty()
            .WithErrorCode("40008")
            .WithMessage(x => this.WithErrorMessage(nameof(x.SPEED)));

        RuleFor(x => x.PLAYBOX_BUNDLE)
            .NotNull().NotEmpty()
            .WithErrorCode("40009")
            .WithMessage(x => this.WithErrorMessage(nameof(x.PLAYBOX_BUNDLE)));

        RuleFor(x => x.PLAYBOX_ADDON)
            .NotNull().NotEmpty()
            .WithErrorCode("40010")
            .WithMessage(x => this.WithErrorMessage(nameof(x.PLAYBOX_ADDON)));

        RuleFor(x => x.ROUTER_BUNDLE)
            .NotNull().NotEmpty()
            .WithErrorCode("40011")
            .WithMessage(x => this.WithErrorMessage(nameof(x.ROUTER_BUNDLE)));

        RuleFor(x => x.ROUTER_ADDON)
            .NotNull().NotEmpty()
            .WithErrorCode("40012")
            .WithMessage(x => this.WithErrorMessage(nameof(x.ROUTER_ADDON)));

        RuleFor(x => x.PRICE)
            .NotNull().NotEmpty()
            .WithErrorCode("40013")
            .WithMessage(x => this.WithErrorMessage(nameof(x.PRICE)));

        RuleFor(x => x.FIRSTNAME)
            .NotNull().NotEmpty()
            .WithErrorCode("40014")
            .WithMessage(x => this.WithErrorMessage(nameof(x.FIRSTNAME)));

        RuleFor(x => x.LASTNAME)
            .NotNull().NotEmpty()
            .WithErrorCode("40015")
            .WithMessage(x => this.WithErrorMessage(nameof(x.LASTNAME)));

        RuleFor(x => x.TELEPHONE)
            .NotNull().NotEmpty()
            .WithErrorCode("40016")
            .WithMessage(x => this.WithErrorMessage(nameof(x.TELEPHONE)));

        RuleFor(x => x.EMAIL)
            .NotNull().NotEmpty()
            .WithErrorCode("40017")
            .WithMessage(x => this.WithErrorMessage(nameof(x.EMAIL)));

        RuleFor(x => x.ADDRESS)
            .NotNull().NotEmpty()
            .WithErrorCode("40018")
            .WithMessage(x => this.WithErrorMessage(nameof(x.ADDRESS)));

        RuleFor(x => x.SUBDISTRICT)
            .NotNull().NotEmpty()
            .WithErrorCode("40019")
            .WithMessage(x => this.WithErrorMessage(nameof(x.SUBDISTRICT)));

        RuleFor(x => x.DISTRICT)
            .NotNull().NotEmpty()
            .WithErrorCode("40020")
            .WithMessage(x => this.WithErrorMessage(nameof(x.DISTRICT)));

        RuleFor(x => x.PROVINCE)
            .NotNull().NotEmpty()
            .WithErrorCode("40021")
            .WithMessage(x => this.WithErrorMessage(nameof(x.PROVINCE)));

        RuleFor(x => x.ZIPCODE)
            .NotNull().NotEmpty()
            .WithErrorCode("40022")
            .WithMessage(x => this.WithErrorMessage(nameof(x.ZIPCODE)));

        RuleFor(x => x.MEDIA_STREAMING)
            .NotNull().NotEmpty()
            .WithErrorCode("40023")
            .WithMessage(x => this.WithErrorMessage(nameof(x.MEDIA_STREAMING)));

        RuleFor(x => x.USER_JOURNEY)
            .NotNull().NotEmpty()
            .WithErrorCode("40024")
            .WithMessage(x => this.WithErrorMessage(nameof(x.USER_JOURNEY)));

        RuleFor(x => x.CID)
            .NotNull().NotEmpty()
            .WithErrorCode("40025")
            .WithMessage(x => this.WithErrorMessage(nameof(x.CID)));

        RuleFor(x => x.COMPLETE)
            .NotNull().NotEmpty()
            .WithErrorCode("40026")
            .WithMessage(x => this.WithErrorMessage(nameof(x.COMPLETE)));

    }
}
