using EntityLayer.WebApp.ViewModels.Common;

namespace EntityLayer.WebApp.ViewModels.Contact
{
    public class ContactUsAddVM : IBaseAddVM
    {
        public string Location { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Call { get; set; } = null!;
        public string Map { get; set; } = null!;
    }
}
