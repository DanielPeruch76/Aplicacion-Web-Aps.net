using EntityLayer.WebApp.ViewModels.Category;
using EntityLayer.WebApp.ViewModels.Common;
namespace EntityLayer.WebApp.ViewModels.Portafolio
{
    public class PortafolioListVM : IBaseVM
    {
        public int Id { get; set; }
        public string CreateDate { get; set; } = DateTime.Now.ToString("d");
        public string? UpdateDate { get; set; }
        public string Title { get; set; } = null!;
        public string FileName { get; set; } = null!;
        public string FileType { get; set; } = null!;

        public int CategoryId { get; set; }
        public CategoryListVM Category { get; set; } = null!;
    }
}
