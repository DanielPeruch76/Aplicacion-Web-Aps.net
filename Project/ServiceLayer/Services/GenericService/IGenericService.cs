using EntityLayer.WebApp.ViewModels.Common;

namespace ServiceLayer.Services.GenericService
{
    public interface IGenericService<TListVM, TAddVM, TUpdateVM, PK>
        where TListVM : class, IBaseVM, new()
        where TAddVM : class, IBaseAddVM, new()
        where TUpdateVM : class, IBaseUpDateVM, new()
    {
        Task<List<TListVM>> GetAllListAsync();
        Task<TUpdateVM> GetByIdAsync(PK id);
        Task AddAsync(TAddVM request);
        Task UpDateAsync(TUpdateVM request);
        Task DeleteAsync(PK id);
        Task <bool> ExistAsync(PK id);
    }
}
