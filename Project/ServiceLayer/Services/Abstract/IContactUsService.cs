using EntityLayer.WebApp.ViewModels.Contact;
using ServiceLayer.Services.GenericService;

namespace ServiceLayer.Services.Abstract
{
    public interface IContactUsService : IGenericService<ContactUsListVM, ContactUsAddVM, ContactUsUpdateVM, int>
    {
    }
}
