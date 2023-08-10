using MiniERP.Web.ViewModels;


namespace MiniERP.Services.Data.Interfaces
{
	/// <summary>
	/// This interface is used to define the methods for the Product Service
	/// </summary>
	public interface IProductService
	{
		public Task AddProduct(ProductViewModel product);
		public  Task<IEnumerable<ProductViewModel>> GetAllProducts();
		public  Task <ProductViewModel>  GetProduct(int id);
		public Task<bool> Exists(int id);
		public Task EditProduct(ProductViewModel product);
	}
}
