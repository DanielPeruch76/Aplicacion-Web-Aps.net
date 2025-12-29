using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RepositoryLayer.Context;
using RepositoryLayer.Repositories.Abstract;
using RepositoryLayer.Repositories.Concrete;
using RepositoryLayer.UnitOfWork.Abstract;
using RepositoryLayer.UnitOfWork.Concrete;

namespace RepositoryLayer.Extensions
{
    public static class RepositoryLayerExtensions
    {
        public static IServiceCollection LoadRepositoryLayerExtensions(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(config.GetConnectionString("SqlConnection")));
            services.AddTransient(typeof(IGenericRepositories<,>),typeof(GenericRepositories<,>));
            services.AddScoped<IUnitOfWork,UnitOfWorks>();
            return services;
        }
    }
}
