using EntityLayer.WebApp.ViewModels.SocialMedia;
using ServiceLayer.Services.GenericService;

namespace ServiceLayer.Services.Abstract
{
    public interface ISocialMediaService : IGenericService<SocialMediaListVM,SocialMediaAddVM, SocialMediaUpdateVM, int>
    {
    }
}
