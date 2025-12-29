using EntityLayer.WebApp.ViewModels.Service;
using FluentValidation;
namespace ServiceLayer.FluentValidation.WebApp.ServiceValidation
{
    public class ServiceUpdateValidation : AbstractValidator<ServiceUpdateVM>
    {
        public ServiceUpdateValidation()
        {
            RuleFor(x => x.Name)
               .NotEmpty()
               .NotNull()
               .MaximumLength(200);
            RuleFor(x => x.Description)
                .NotEmpty()
                .NotNull()
                .MaximumLength(2000);
            RuleFor(x => x.Icon)
                .NotEmpty()
                .NotNull()
                .MaximumLength(100);
        }
    }
}
