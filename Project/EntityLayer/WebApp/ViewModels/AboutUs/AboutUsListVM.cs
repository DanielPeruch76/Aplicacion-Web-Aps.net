using EntityLayer.WebApp.ViewModels.Common;
using EntityLayer.WebApp.ViewModels.SocialMedia;
namespace EntityLayer.WebApp.ViewModels.AboutUsVM
{
    public class AboutUsListVM : IBaseVM
    {
        public int Id { get; set; }
        public string CreateDate { get; set; } = DateTime.Now.ToString("d");
        public string? UpdateDate { get; set; }
        public string Header { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int Clients { get; set; }
        public int Projects { get; set; }
        public int HoursOfSupport { get; set; }
        public int HardWorkers { get; set; }
        public string FileName { get; set; } = null!;
        public string FileType { get; set; } = null!;
        public int SocialMediaId { get; set; }

        public SocialMediaListVM SocialMedia { get; set; } = null!;
    }
}
