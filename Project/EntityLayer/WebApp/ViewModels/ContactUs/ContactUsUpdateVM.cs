using EntityLayer.WebApp.ViewModels.Common;

namespace EntityLayer.WebApp.ViewModels.Contact
{
    public class ContactUsUpdateVM : IBaseUpDateVM
    {
        public int Id { get; set; }
        public string? UpdateDate { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public string Location { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Call { get; set; } = null!;
        public string Map { get; set; } = null!;
    }
}
