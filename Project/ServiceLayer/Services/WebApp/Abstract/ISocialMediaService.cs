using EntityLayer.WebApp.ViewModels.SocialMedia;
using ServiceLayer.Services.WebApp.GenericService;

namespace ServiceLayer.Services.WebApp.Abstract
{
    public interface ISocialMediaService : IGenericService<SocialMediaListVM,SocialMediaAddVM, SocialMediaUpdateVM, int>
    {
    }
}
