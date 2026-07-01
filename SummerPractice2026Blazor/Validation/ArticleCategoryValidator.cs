using FluentValidation;
using SummerPractice2026Blazor.Repository.Entities;

namespace SummerPractice2026Blazor.Validation
{
    public class ArticleCategoryValidator : AbstractValidator<ArticleCategory>
    {
        public ArticleCategoryValidator()
        {
            RuleFor(x => x.Name)
            .NotEmpty().WithMessage("Name is requiered.")
            .MaximumLength(100).WithMessage("The Name cannot be over 100 characters");
        }

    }
}
