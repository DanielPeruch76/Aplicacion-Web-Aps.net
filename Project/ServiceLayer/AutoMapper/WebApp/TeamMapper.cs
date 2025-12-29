using AutoMapper;
using EntityLayer.WebApp.Entities;
using EntityLayer.WebApp.ViewModels.Team;

namespace ServiceLayer.AutoMapper.WebApp
{
    public class TeamMapper : Profile
    {
        public TeamMapper()
        {
            CreateMap<Team,TeamAddVM>().ReverseMap();
            CreateMap<Team,TeamListVM>().ReverseMap();
            CreateMap<Team,TeamUpdateVM>().ReverseMap();
        }
    }
}
