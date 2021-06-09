using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class AuthorValidator : AbstractValidator<Author>
    {
        public AuthorValidator()
        {
            RuleFor(a => a.Name).NotEmpty();
            RuleFor(a => a.Nationality).NotEmpty();
            RuleFor(a => a.BookCount).NotEmpty();
            RuleFor(a => a.BookCount).GreaterThan(0);

        }
    }
}