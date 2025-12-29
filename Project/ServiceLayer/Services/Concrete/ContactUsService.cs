using AutoMapper;
using EntityLayer.WebApp.Entities;
using EntityLayer.WebApp.ViewModels.Contact;
using RepositoryLayer.UnitOfWork.Abstract;
using ServiceLayer.Services.Abstract;
using ServiceLayer.Services.GenericService;

namespace ServiceLayer.Services.Concrete
{
    public class ContactUsService : GenericService<ContactUs, ContactUsListVM, ContactUsAddVM, ContactUsUpdateVM, int>,
        IContactUsService
    {
        public ContactUsService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }
    }
}
