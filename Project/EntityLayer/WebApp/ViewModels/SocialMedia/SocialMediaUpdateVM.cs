using EntityLayer.WebApp.ViewModels.AboutUsVM;
using EntityLayer.WebApp.ViewModels.Common;
namespace EntityLayer.WebApp.ViewModels.SocialMedia
{
    public class SocialMediaUpdateVM : IBaseUpDateVM
    {
        public int Id { get; set; }
        public string? UpdateDate { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public string? Twitter { get; set; }
        public string? Linkedin { get; set; }
        public string? FaceBook { get; set; }
        public string? Instagram { get; set; }

        public AboutUsUpDateVM AboutUs { get; set; } = null!;
    }
}
