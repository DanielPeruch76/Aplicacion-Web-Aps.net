using CoreLayer.BaseEntities;
namespace EntityLayer.WebApp.Entities
{
    public class Portafolio : BaseEntity<int>
    {
        public string Title { get; set; } = null!;
        public string FileName { get; set; } = null!;
        public string FileType { get; set; } = null!;

        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;
    }
}
