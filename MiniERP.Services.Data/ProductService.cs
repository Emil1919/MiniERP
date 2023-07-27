using Mini_ERP.Data;
using MiniERP.Data.Models.CustomerData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP.Services.Data
{
	public class ProductService: Interfaces.IProductService
	{
		private readonly MiniERP_DbContext dbContext;
        public ProductService(MiniERP_DbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task < HashSet<Product>> GetAllProducts()
		{
			return await dbContext.Products().ToHashSetAsync();
			
		}
	}
}
