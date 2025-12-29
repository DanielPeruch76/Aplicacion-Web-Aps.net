using AutoMapper;
using EntityLayer.WebApp.Entities;
using EntityLayer.WebApp.ViewModels.AboutUsVM;
using RepositoryLayer.UnitOfWork.Abstract;
using ServiceLayer.Services.WebApp.Abstract;
using ServiceLayer.Services.WebApp.GenericService;

namespace ServiceLayer.Services.WebApp.Concrete
{
    public class AboutUsService : GenericService<AboutUs, AboutUsListVM, AboutUsAddVM, AboutUsUpDateVM, int>,
        IAboutUsService
    {
        public AboutUsService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }
    }
}
