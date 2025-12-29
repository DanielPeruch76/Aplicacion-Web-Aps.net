using CoreLayer.BaseEntities;
namespace EntityLayer.WebApp.Entities
{
    public class SocialMedia : BaseEntity<int>
    {
        public string? Twitter { get; set; }
        public string? Linkedin { get; set; }
        public string? FaceBook { get; set; }
        public string? Instagram { get; set; }

        public AboutUs AboutUs { get; set; } = null!;
    }
}
