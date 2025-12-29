using EntityLayer.WebApp.ViewModels.AboutUsVM;
using EntityLayer.WebApp.ViewModels.Common;
namespace EntityLayer.WebApp.ViewModels.SocialMedia
{
    public class SocialMediaAddVM : IBaseAddVM
    {
        public string? Twitter { get; set; }
        public string? Linkedin { get; set; }
        public string? FaceBook { get; set; }
        public string? Instagram { get; set; }

        public AboutUsAddVM AboutUs { get; set; } = null!;
    }
}
