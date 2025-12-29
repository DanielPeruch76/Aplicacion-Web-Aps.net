using CoreLayer.BaseEntities;
namespace EntityLayer.WebApp.Entities
{
    public class Team : BaseEntity<int>
    {
        public string FullName { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string FileName { get; set; } = null!;
        public string FileType { get; set; } = null!;
        public string? Twitter {  get; set; }
        public string? Linkedin { get; set; }
        public string? FaceBook { get; set; }
        public string? Instagram { get; set; }
    }
}
