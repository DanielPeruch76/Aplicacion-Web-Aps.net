using EntityLayer.WebApp.ViewModels.Common;
namespace EntityLayer.WebApp.ViewModels.Team
{
    public class TeamListVM : IBaseVM
    {
        public int Id { get; set; }
        public string CreateDate { get; set; } = DateTime.Now.ToString("d");
        public string? UpdateDate { get; set; }
        public string FullName { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string FileName { get; set; } = null!;
        public string FileType { get; set; } = null!;
        public string? Twitter { get; set; }
        public string? Linkedin { get; set; }
        public string? FaceBook { get; set; }
        public string? Instagram { get; set; }
    }
}
