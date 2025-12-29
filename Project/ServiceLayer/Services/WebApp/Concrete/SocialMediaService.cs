using AutoMapper;
using EntityLayer.WebApp.Entities;
using EntityLayer.WebApp.ViewModels.SocialMedia;
using RepositoryLayer.UnitOfWork.Abstract;
using ServiceLayer.Services.WebApp.Abstract;
using ServiceLayer.Services.WebApp.GenericService;

namespace ServiceLayer.Services.WebApp.Concrete
{
    public class SocialMediaService : GenericService<SocialMedia, SocialMediaListVM, SocialMediaAddVM, SocialMediaUpdateVM, int>,
        ISocialMediaService
    {
        public SocialMediaService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }
    }
}
