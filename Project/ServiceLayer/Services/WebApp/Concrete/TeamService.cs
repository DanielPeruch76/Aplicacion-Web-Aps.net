using AutoMapper;
using EntityLayer.WebApp.Entities;
using EntityLayer.WebApp.ViewModels.Team;
using RepositoryLayer.UnitOfWork.Abstract;
using ServiceLayer.Services.WebApp.Abstract;
using ServiceLayer.Services.WebApp.GenericService;

namespace ServiceLayer.Services.WebApp.Concrete
{
    public class TeamService : GenericService<Team, TeamListVM, TeamAddVM, TeamUpdateVM, int>,
        ITeamService
    {
        public TeamService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }
    }
}
