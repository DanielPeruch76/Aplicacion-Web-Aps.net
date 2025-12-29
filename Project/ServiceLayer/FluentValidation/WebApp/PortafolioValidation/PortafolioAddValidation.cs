using EntityLayer.WebApp.ViewModels.Portafolio;
using FluentValidation;

namespace ServiceLayer.FluentValidation.WebApp.PortafolioValidation
{
    public class PortafolioAddValidation : AbstractValidator<PortafolioAddVM>
    {
        public PortafolioAddValidation()
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
            RuleFor(x => x.Photo)
                .NotEmpty()
                .NotNull();
        }
    }
}
