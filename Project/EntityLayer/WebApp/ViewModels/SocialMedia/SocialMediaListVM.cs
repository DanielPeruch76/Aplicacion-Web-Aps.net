using EntityLayer.WebApp.ViewModels.AboutUsVM;
using EntityLayer.WebApp.ViewModels.Common;
namespace EntityLayer.WebApp.ViewModels.SocialMedia
{
    public class SocialMediaListVM : IBaseVM
    {
        public int Id { get; set; }
        public string CreateDate { get; set; } = DateTime.Now.ToString("d");
        public string? UpdateDate { get; set; }
        public string? Twitter { get; set; }
        public string? Linkedin { get; set; }
        public string? FaceBook { get; set; }
        public string? Instagram { get; set; }

        public AboutUsListVM AboutUs { get; set; } = null!;
    }
}
