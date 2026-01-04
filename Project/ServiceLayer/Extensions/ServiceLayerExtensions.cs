using EntityLayer.WebApp.ViewModels.Category;
using EntityLayer.WebApp.ViewModels.Contact;
using EntityLayer.WebApp.ViewModels.HomePage;
using EntityLayer.WebApp.ViewModels.Portafolio;
using EntityLayer.WebApp.ViewModels.Service;
using EntityLayer.WebApp.ViewModels.Testimonial;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using ServiceLayer.Extensions.Identity;
using ServiceLayer.FluentValidation.WebApp.AboutValidation;
using ServiceLayer.FluentValidation.WebApp.TeamValidation;
using System.Reflection;
namespace ServiceLayer.Extensions
{
    public static class ServiceLayerExtensions
    {
        public static IServiceCollection LoadServiceLayerExtensions(this IServiceCollection services)
        {
            services.LoadIdentityExtensions();
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            var types = Assembly.GetExecutingAssembly().GetTypes().Where(x => x.IsClass && !x.IsAbstract && x.Name.EndsWith("Service"));

            foreach(var serviceType in types)
            {
                var isServiceType = serviceType.GetInterfaces().FirstOrDefault(x => x.Name == $"I{serviceType.Name}");
                if (isServiceType != null) { 
                    services.AddScoped(isServiceType, serviceType);
                }
            }

            services.AddFluentValidationAutoValidation(opt =>
            {
                opt.DisableDataAnnotationsValidation = true;
            });

            services.AddValidatorsFromAssemblyContaining<AboutUsAddValidation>();
            services.AddValidatorsFromAssemblyContaining<AboutUsUpadateValidation>();
            services.AddValidatorsFromAssemblyContaining<CategoryAddVM>();
            services.AddValidatorsFromAssemblyContaining<CategoryUpDateVM>();
            services.AddValidatorsFromAssemblyContaining<ContactUsAddVM>();
            services.AddValidatorsFromAssemblyContaining<ContactUsUpdateVM>();
            services.AddValidatorsFromAssemblyContaining<HomePageAddVM>();
            services.AddValidatorsFromAssemblyContaining<HomePageUpdateVM>();
            services.AddValidatorsFromAssemblyContaining<PortafolioAddVM>();
            services.AddValidatorsFromAssemblyContaining<PortafolioUpdateVM>();
            services.AddValidatorsFromAssemblyContaining<ServiceAddVM>();
            services.AddValidatorsFromAssemblyContaining<ServiceUpdateVM>();
            services.AddValidatorsFromAssemblyContaining<TeamAddValidation>();
            services.AddValidatorsFromAssemblyContaining<TeamUpdateValidation>();
            services.AddValidatorsFromAssemblyContaining<TestimonialAddVM>();
            services.AddValidatorsFromAssemblyContaining<TestimonialUpdateVM>();

            return services;
        }
    }
}
