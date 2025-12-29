using EntityLayer.WebApp.ViewModels.Common;
namespace EntityLayer.WebApp.ViewModels.Service
{
    public class ServiceAddVM : IBaseAddVM
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Icon { get; set; } = null!;
    }
}
