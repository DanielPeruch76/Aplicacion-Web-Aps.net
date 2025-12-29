using EntityLayer.WebApp.ViewModels.Team;
using ServiceLayer.Services.GenericService;

namespace ServiceLayer.Services.Abstract
{
    public interface ITeamService : IGenericService<TeamListVM, TeamAddVM, TeamUpdateVM, int> 
    {
    }
}
