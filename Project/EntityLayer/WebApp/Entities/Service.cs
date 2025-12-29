using CoreLayer.BaseEntities;
namespace EntityLayer.WebApp.Entities
{
    public class Service : BaseEntity<int>
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Icon { get; set; } = null!;
    }
}
