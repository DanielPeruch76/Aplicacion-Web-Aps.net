using EntityLayer.WebApp.ViewModels.Common;

namespace EntityLayer.WebApp.ViewModels.HomePage
{
    public class HomePageListVM : IBaseVM
    {
        public int Id { get; set; }
        public string CreateDate { get; set; } = DateTime.Now.ToString("d");
        public string? UpdateDate { get; set; }
        public string Header { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string VideoLink { get; set; } = null!;
    }
}
