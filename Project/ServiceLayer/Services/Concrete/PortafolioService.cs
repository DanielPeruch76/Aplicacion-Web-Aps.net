using AutoMapper;
using EntityLayer.WebApp.Entities;
using EntityLayer.WebApp.ViewModels.Portafolio;
using RepositoryLayer.UnitOfWork.Abstract;
using ServiceLayer.Services.Abstract;
using ServiceLayer.Services.GenericService;

namespace ServiceLayer.Services.Concrete
{
    public class PortafolioService : GenericService<Portafolio, PortafolioListVM, PortafolioAddVM, PortafolioUpdateVM, int>,
        IPortafolioService
    {
        public PortafolioService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }
    }
}
