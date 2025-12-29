using EntityLayer.WebApp.ViewModels.Contact;
using FluentValidation;

namespace ServiceLayer.FluentValidation.WebApp.ContactUsValidation
{
    public class ContactAddValidation : AbstractValidator<ContactUsAddVM>
    {
        public ContactAddValidation()
        {
            RuleFor(x => x.Location)
                .NotEmpty()
                .NotNull()
                .MaximumLength(200);
            RuleFor(x => x.Email)
                .NotEmpty()
                .NotNull()
                .MaximumLength(100);
            RuleFor(x => x.Call)
                .NotEmpty()
                .NotNull()
                .MaximumLength(17);
            RuleFor(x => x.Map)
                .NotEmpty()
                .NotNull();
        }
    }
}
