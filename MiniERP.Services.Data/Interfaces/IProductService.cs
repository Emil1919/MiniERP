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
		public  Task<IEnumerable<ProductViewModel>> GetAllProducts();
	}
}
