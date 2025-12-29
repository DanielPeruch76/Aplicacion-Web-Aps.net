using EntityLayer.WebApp.ViewModels.HomePage;
using FluentValidation;

namespace ServiceLayer.FluentValidation.WebApp.HomePageValidation
{
    public class HomePageUpdateValidation : AbstractValidator<HomePageUpdateVM>
    {
        public HomePageUpdateValidation()
        {
            RuleFor(x => x.Header)
                .NotEmpty()
                .NotNull()
                .MaximumLength(200);
            RuleFor(x => x.Description)
                .NotEmpty()
                .NotNull()
                .MaximumLength(2000);
            RuleFor(x => x.VideoLink)
                .NotEmpty()
                .NotNull();
        }
    }
}
