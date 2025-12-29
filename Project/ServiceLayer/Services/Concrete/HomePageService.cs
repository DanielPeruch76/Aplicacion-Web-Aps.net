using AutoMapper;
using EntityLayer.WebApp.Entities;
using EntityLayer.WebApp.ViewModels.HomePage;
using RepositoryLayer.UnitOfWork.Abstract;
using ServiceLayer.Services.Abstract;
using ServiceLayer.Services.GenericService;

namespace ServiceLayer.Services.Concrete
{
    public class HomePageService : GenericService<HomePage, HomePageListVM, HomePageAddVM, HomePageUpdateVM, int>,
        IHomePageService
    {
        public HomePageService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }
    }
}
