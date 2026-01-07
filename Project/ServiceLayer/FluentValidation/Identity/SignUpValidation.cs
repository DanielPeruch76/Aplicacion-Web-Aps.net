using EntityLayer.Identity.ViewModels;
using FluentValidation;
using ServiceLayer.Messages.Identity;
using ServiceLayer.Messages.WebApp;

namespace ServiceLayer.FluentValidation.Identity
{
    public class SignUpValidation : AbstractValidator<SignUpVM>
    {
        public SignUpValidation()
        {
            RuleFor(x => x.UserName)
                .NotNull().WithMessage(ValidationMessages.NullEmptyMessage("Username"))
                .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessage("Username"));
            RuleFor(x => x.Email)
                .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessage("Email"))
                .NotNull().WithMessage(ValidationMessages.NullEmptyMessage("Email"))
                .EmailAddress().WithMessage(IdentityMessages.CheckEmailAdrress());
            RuleFor(x => x.Password)
                .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessage("Password"))
                .NotNull().WithMessage(ValidationMessages.NullEmptyMessage("Password"));
            RuleFor(x => x.ConfirmPassword)
                .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessage("ConfirmPassword"))
                .NotNull().WithMessage(ValidationMessages.NullEmptyMessage("ConfirmPassword"))
                .Equal(x => x.Password).WithMessage(IdentityMessages.ComparePassword());
        }
    }
}
