using MiniERP.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP.Services.Data.Interfaces
{
	public interface IProductService
	{
		public Task AddProduct(ProductViewModel product);
		public  Task<IEnumerable<ProductViewModel>> GetAllProducts();
		public Task <ProductViewModel> GetProduct(int id);
		public Task<bool> Exists(int id);
	}
}
