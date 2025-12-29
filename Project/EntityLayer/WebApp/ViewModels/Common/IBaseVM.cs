namespace EntityLayer.WebApp.ViewModels.Common
{
    public interface IBaseVM
    {
        public int Id { get; set; }
    }

    public interface IBaseAddVM
    {

    }
    public interface IBaseUpDateVM : IBaseVM
    {
        public byte[] RowVersion { get; set; }
    }
}
