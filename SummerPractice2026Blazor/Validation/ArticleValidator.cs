using FluentValidation;
using SummerPractice2026Blazor.Repository.Entities;

namespace SummerPractice2026Blazor.Validation
{
    public class ArticleValidator : AbstractValidator<Article>
    {
        public ArticleValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Name is required.")
                .MaximumLength(150).WithMessage("Name cannot exceed 150 characters.");
            RuleFor(x => x.Price)
              .ExclusiveBetween(0.01m, 1000m).WithMessage("Price must be between 0.01 and 1000.");
            RuleFor(x => x.ArticleCategoryId)
                .NotEmpty().WithMessage("Category is required.");
        }
    }
}
