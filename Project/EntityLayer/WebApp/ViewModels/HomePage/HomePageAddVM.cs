

using EntityLayer.WebApp.ViewModels.Common;

namespace EntityLayer.WebApp.ViewModels.HomePage
{
    public class HomePageAddVM : IBaseAddVM
    {
        public string Header { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string VideoLink { get; set; } = null!;
    }
}
