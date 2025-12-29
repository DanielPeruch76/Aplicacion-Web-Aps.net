using CoreLayer.BaseEntities;
namespace EntityLayer.WebApp.Entities
{
    public class Testimonial : BaseEntity<int>
    {
        public string Comment { get; set; } = null!;
        public string FullName { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string FileName { get; set; } = null!;
        public string FileType { get; set; } = null!;
    }
}
