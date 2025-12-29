using EntityLayer.WebApp.ViewModels.Category;
using FluentValidation;

namespace ServiceLayer.FluentValidation.WebApp.CategoryValidation
{
    public class CategoryAddValidation : AbstractValidator<CategoryAddVM>
    {
        public CategoryAddValidation()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .NotNull()
                .MaximumLength(50);
        }
    }
}
