using EntityLayer.WebApp.ViewModels.Common;
using EntityLayer.WebApp.ViewModels.SocialMedia;
using Microsoft.AspNetCore.Http;

namespace EntityLayer.WebApp.ViewModels.AboutUsVM
{
    public class AboutUsAddVM : IBaseAddVM
    {
        public string Header { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int Clients { get; set; }
        public int Projects { get; set; }
        public int HoursOfSupport { get; set; }
        public int HardWorkers { get; set; }
        public string FileName { get; set; } = null!;
        public string FileType { get; set; } = null!;
        public IFormFile Photo { get; set; } = null!;
        public int SocialMediaId { get; set; }

        public SocialMediaAddVM SocialMedia { get; set; } = null!;
    }
}
