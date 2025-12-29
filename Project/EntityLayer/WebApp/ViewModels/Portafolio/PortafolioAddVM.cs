using EntityLayer.WebApp.ViewModels.Category;
using EntityLayer.WebApp.ViewModels.Common;
using Microsoft.AspNetCore.Http;
namespace EntityLayer.WebApp.ViewModels.Portafolio
{
    public class PortafolioAddVM : IBaseAddVM
    {
        public string Title { get; set; } = null!;
        public string FileName { get; set; } = null!;
        public string FileType { get; set; } = null!;
        public IFormFile Photo { get; set; } = null!;
        public int CategoryId { get; set; }
        public CategoryAddVM Category { get; set; } = null!;
    }
}
