using Microsoft.EntityFrameworkCore;
using Mini_ERP.Data;
using MiniERP.Data.Models;
using MiniERP.Web.ViewModels;
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

		public async Task AddProduct(ProductViewModel product)
		{
			Product newProduct = new Product
			{
				Name = product.Name,
				Description = product.Description,
				Price = product.Price,
				Quantity = product.Quantity,
				Image = product.Image
				
			};
			await dbContext.Products.AddAsync(newProduct);
			await dbContext.SaveChangesAsync();
		}

		public async Task < IEnumerable<ProductViewModel>> GetAllProducts()
		{
			return await dbContext.Products.Select(x => new ProductViewModel
			{
				Id = x.Id,
				Name = x.Name,
				Description = x.Description,
				Price = x.Price,
				Quantity = x.Quantity,
				Image = x.Image
			}).ToListAsync();


		}
	}
}
