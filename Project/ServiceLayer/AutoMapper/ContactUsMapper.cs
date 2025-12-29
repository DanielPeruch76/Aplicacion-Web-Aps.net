using AutoMapper;
using EntityLayer.WebApp.Entities;
using EntityLayer.WebApp.ViewModels.AboutUsVM;
using EntityLayer.WebApp.ViewModels.Contact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.AutoMapper
{
    public class ContactUsMapper : Profile
    {
        public ContactUsMapper()
        {
            CreateMap<ContactUs, ContactUsAddVM>().ReverseMap();
            CreateMap<ContactUs, ContactUsListVM>().ReverseMap();
            CreateMap<ContactUs, ContactUsUpdateVM>().ReverseMap();
        }
    }
}
