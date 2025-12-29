using EntityLayer.WebApp.ViewModels.Team;
using FluentValidation;
namespace ServiceLayer.FluentValidation.WebApp.TeamValidation
{
    public class TeamAddValidation : AbstractValidator<TeamAddVM>
    {
        public TeamAddValidation()
        {
            RuleFor(x => x.FullName)
                .NotEmpty()
                .NotNull()
                .MaximumLength(100);
            RuleFor(x => x.Title)
                .NotEmpty()
                .NotNull()
                .MaximumLength(100);
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
