using EntityLayer.WebApp.ViewModels.Portafolio;
using FluentValidation;

namespace ServiceLayer.FluentValidation.WebApp.PortafolioValidation
{
    public class PortafolioUpdateValidation : AbstractValidator<PortafolioUpdateVM>
    {
        public PortafolioUpdateValidation()
        {
            RuleFor(x => x.Title)
               .NotEmpty()
               .NotNull()
               .MaximumLength(200);
            RuleFor(x => x.FileName)
                .NotEmpty()
                .NotNull();
            RuleFor(x => x.FileType)
                .NotEmpty()
                .NotNull();
        }
    }
}
