using EntityLayer.WebApp.ViewModels.AboutUsVM;
using FluentValidation;
using ServiceLayer.Messages.WebApp;

namespace ServiceLayer.FluentValidation.WebApp.AboutValidation
{
    public class AboutUsAddValidation : AbstractValidator<AboutUsAddVM>
    {
        public AboutUsAddValidation()
        {
            RuleFor(x => x.Header)
                .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessage("Header"))
                .NotNull().WithMessage(ValidationMessages.NullEmptyMessage("Header"))
                .MaximumLength(200).WithMessage(ValidationMessages.MaxinumCharachterAllowence("Header", 200));
            RuleFor(x => x.Description)
                .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessage("Descripcion"))
                .NotNull().WithMessage(ValidationMessages.NullEmptyMessage("Descripcion"))
                .MaximumLength(5000).WithMessage(ValidationMessages.MaxinumCharachterAllowence("Descripcion", 5000));
            RuleFor(x => x.Clients)
                .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessage("Clients"))
                .NotNull().WithMessage(ValidationMessages.NullEmptyMessage("Clients"))
                .GreaterThan(0).WithMessage(ValidationMessages.GreaterThanMessage("Clients",0))
                .LessThan(100).WithMessage(ValidationMessages.LessThanMessage("Clients", 100));
            RuleFor(x => x.Projects)
                .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessage("Projects"))
                .NotNull().WithMessage(ValidationMessages.NullEmptyMessage("Projects"))
                .GreaterThan(0).WithMessage(ValidationMessages.GreaterThanMessage("Projects", 0))
                .LessThan(100).WithMessage(ValidationMessages.LessThanMessage("Projects", 100));
            RuleFor(x => x.HoursOfSupport)
                .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessage("Hours of Support"))
                .NotNull().WithMessage(ValidationMessages.NullEmptyMessage("Hours of Suport"))
                .GreaterThan(0).WithMessage(ValidationMessages.GreaterThanMessage("Hours of Support", 0))
                .LessThan(100).WithMessage(ValidationMessages.LessThanMessage("Hours of Support", 100));
            RuleFor(x => x.HardWorkers)
                .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessage("Hard Workers"))
                .NotNull().WithMessage(ValidationMessages.NullEmptyMessage("Hard Workers"))
                .GreaterThan(0).WithMessage(ValidationMessages.GreaterThanMessage("Hard Workers", 0))
                .LessThan(100).WithMessage(ValidationMessages.LessThanMessage("Hard Workers", 100));
            RuleFor(x => x.Photo)
                .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessage("Photo"))
                .NotNull().WithMessage(ValidationMessages.NullEmptyMessage("Photo"));
        }
    }
}
