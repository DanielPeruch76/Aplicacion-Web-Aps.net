using EntityLayer.WebApp.ViewModels.AboutUsVM;
using FluentValidation;
namespace ServiceLayer.FluentValidation.WebApp.AboutValidation
{
    public class AboutUsUpadateValidation : AbstractValidator<AboutUsUpDateVM>
    {
        public AboutUsUpadateValidation()
        {
            RuleFor(x => x.Header)
               .NotEmpty()
               .NotNull()
               .MaximumLength(200);
            RuleFor(x => x.Description)
                .NotEmpty()
                .NotNull()
                .MaximumLength(5000);
            RuleFor(x => x.Clients)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0)
                .LessThan(100);
            RuleFor(x => x.Projects)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0)
                .LessThan(100);
            RuleFor(x => x.HoursOfSupport)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0)
                .LessThan(100);
            RuleFor(x => x.HardWorkers)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0)
                .LessThan(100);
        }
    }
}
