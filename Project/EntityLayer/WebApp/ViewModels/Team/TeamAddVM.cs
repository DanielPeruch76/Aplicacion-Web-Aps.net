using EntityLayer.WebApp.ViewModels.Common;
using Microsoft.AspNetCore.Http;
namespace EntityLayer.WebApp.ViewModels.Team
{
    public class TeamAddVM : IBaseAddVM
    {
        public string FullName { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string FileName { get; set; } = null!;
        public string FileType { get; set; } = null!;
        public string? Twitter { get; set; }
        public string? Linkedin { get; set; }
        public string? FaceBook { get; set; }
        public string? Instagram { get; set; }
        public IFormFile Photo { get; set; } = null!;
    }
}
