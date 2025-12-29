using EntityLayer.WebApp.ViewModels.Contact;
using FluentValidation;

namespace ServiceLayer.FluentValidation.WebApp.ContactUsValidation
{
    public class ContactUpdateValidation : AbstractValidator<ContactUsUpdateVM>
    {
        public ContactUpdateValidation()
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
