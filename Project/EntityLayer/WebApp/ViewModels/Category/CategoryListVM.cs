using EntityLayer.WebApp.ViewModels.Common;

namespace EntityLayer.WebApp.ViewModels.Category
{
    public class CategoryListVM : IBaseVM
    {
        public int Id { get; set; }
        public string CreateDate { get; set; } = DateTime.Now.ToString("d");
        public string? UpdateDate { get; set; }
        public string Name { get; set; } = null!;
    }
}
