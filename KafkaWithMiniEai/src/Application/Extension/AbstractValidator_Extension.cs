using FluentValidation;

namespace Application.Extension;

public static class AbstractValidator_Extension
{
    public static string WithErrorMessage<T>(this AbstractValidator<T> validator, string nameOfParameter, string errorFormat = "'{0}' parameter(s) should not be null or empty.")
    {
        return string.Format(errorFormat, nameOfParameter);
    }
}
