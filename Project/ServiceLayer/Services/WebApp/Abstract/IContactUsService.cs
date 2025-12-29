using EntityLayer.WebApp.ViewModels.Contact;
using ServiceLayer.Services.WebApp.GenericService;

namespace ServiceLayer.Services.WebApp.Abstract
{
    public interface IContactUsService : IGenericService<ContactUsListVM, ContactUsAddVM, ContactUsUpdateVM, int>
    {
    }
}
