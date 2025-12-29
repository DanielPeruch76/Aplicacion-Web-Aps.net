using CoreLayer.BaseEntities;
namespace EntityLayer.WebApp.Entities
{
    public class HomePage : BaseEntity<int>
    {
        public string Header { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string VideoLink { get; set; } = null!;
    }
}
