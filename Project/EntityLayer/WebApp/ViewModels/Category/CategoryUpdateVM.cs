using EntityLayer.WebApp.ViewModels.Common;

namespace EntityLayer.WebApp.ViewModels.Category
{
    public class CategoryUpDateVM : IBaseUpDateVM
    {
        public int Id { get; set; }
        public string? UpdateDate { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public string Name { get; set; } = null!;
    } 
}
