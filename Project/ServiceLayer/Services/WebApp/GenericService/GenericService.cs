using AutoMapper;
using AutoMapper.QueryableExtensions;
using CoreLayer.BaseEntities;
using EntityLayer.WebApp.Entities;
using EntityLayer.WebApp.ViewModels.AboutUsVM;
using EntityLayer.WebApp.ViewModels.Common;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Repositories.Abstract;
using RepositoryLayer.UnitOfWork.Abstract;

namespace ServiceLayer.Services.WebApp.GenericService
{
    public class GenericService <TEntity, TListVM, TAddVM, TUpdateVM, PK>
        : IGenericService<TListVM, TAddVM, TUpdateVM, PK>
        where TEntity : BaseEntity<PK>, new()
        where TListVM : class, IBaseVM, new()
        where TAddVM : class, IBaseAddVM, new()
        where TUpdateVM : class, IBaseUpDateVM, new()
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IGenericRepositories<TEntity,PK> _repository;

        public GenericService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _repository = _unitOfWork.GetGenericRepository<TEntity,PK>();
        }

        public virtual async Task<List<TListVM>> GetAllListAsync()
        {
            var listVM = await _repository.GetAllEntityList().ProjectTo<TListVM>(_mapper.ConfigurationProvider).ToListAsync();
            return listVM;
        }

        public virtual async Task AddAsync(TAddVM request)
        {
            var entity = _mapper.Map<TEntity>(request);
            await _repository.AddEntityAsync(entity);
            await _unitOfWork.CommitAsync();
        }

        public virtual async Task DeleteAsync(PK id)
        {
            var entity = await _repository.GetEntityByIdAsync(id);
            _repository.DeleteEntity(entity);
            await _unitOfWork.CommitAsync();
        }

        public virtual async Task<TUpdateVM> GetByIdAsync(PK id)
        {
            var entity = await _repository.Where(x => x.Id.Equals(id)).ProjectTo<TUpdateVM>(_mapper.ConfigurationProvider).SingleAsync();
            return entity;
        }

        public async Task UpDateAsync(TUpdateVM request)
        {
            var entity = _mapper.Map<TEntity>(request);
            _repository.UpDateEntity(entity);
            await _unitOfWork.CommitAsync();
        }

        public virtual async Task<bool> ExistAsync(PK id)
        {
            var entity = await _repository.GetEntityByIdAsync(id);
            return entity != null;
        }

    }
}
