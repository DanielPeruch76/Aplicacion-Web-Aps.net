using EntityLayer.WebApp.ViewModels.Category;
using FluentValidation;

namespace ServiceLayer.FluentValidation.WebApp.CategoryValidation
{
    public class CategoryUpadteValidation : AbstractValidator<CategoryUpDateVM>
    {
        public CategoryUpadteValidation()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .NotNull()
                .MaximumLength(50);
        }
    }
}
