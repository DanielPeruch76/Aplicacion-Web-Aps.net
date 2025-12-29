using EntityLayer.WebApp.ViewModels.Common;
namespace EntityLayer.WebApp.ViewModels.HomePage
{
    public class HomePageUpdateVM : IBaseUpDateVM
    {
        public int Id { get; set; }
        public string? UpdateDate { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public string Header { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string VideoLink { get; set; } = null!;
    }
}
