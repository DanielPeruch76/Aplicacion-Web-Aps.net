using EntityLayer.WebApp.ViewModels.Team;
using ServiceLayer.Services.WebApp.GenericService;

namespace ServiceLayer.Services.WebApp.Abstract
{
    public interface ITeamService : IGenericService<TeamListVM, TeamAddVM, TeamUpdateVM, int> 
    {
    }
}
