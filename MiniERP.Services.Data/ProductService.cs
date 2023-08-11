using Microsoft.EntityFrameworkCore;
using Mini_ERP.Data;
using MiniERP.Data.Models;
using MiniERP.Web.ViewModels;


namespace MiniERP.Services.Data
{
	// Coment( this class is responsible for the logic of the product)
	/// <summary>
	/// This class is responsible for the logic of the product
	/// </summary>
	public class ProductService: Interfaces.IProductService
	{
		private readonly MiniERP_DbContext dbContext;
        public ProductService(MiniERP_DbContext dbContext)
        {
            this.dbContext = dbContext;
        }

		public  Task AddProduct(ProductViewModel product)
		{
			Product newProduct = new Product
			{
				Name = product.Name,
				Description = product.Description,
				Price = product.Price,
				Quantity = product.Quantity,
				Image = product.Image,
				IsNew = product.IsNew
				
				
				
			};
			 dbContext.Products.Add(newProduct);
			 dbContext.SaveChanges();
			return Task.CompletedTask;
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
				Image = x.Image,
				IsNew=x.IsNew,
				IsDeleted=x.IsDeleted
			}).ToListAsync();


		}

		public async Task<bool> Exists(int id)
		{
			return await dbContext.Products.AnyAsync(x => x.Id == id);
		}

		public async Task <ProductViewModel> GetProduct(int id)
		{

				ProductViewModel currentProduct = await dbContext.Products.Where(x => x.Id == id).Select(x => new ProductViewModel
				{
					Id = x.Id,
					Name = x.Name,
					Description = x.Description,
					Price = x.Price,
					Quantity = x.Quantity,
					Image = x.Image,
					IsNew = x.IsNew
					
				}).FirstAsync();

			return currentProduct;
			
			
		}

        public async Task EditProduct(ProductViewModel product)
        {
			var productToEdit = dbContext.Products.FirstOrDefault(x => x.Id == product.Id);
			productToEdit.Name = product.Name;
			productToEdit.Description = product.Description;
			productToEdit.Price = product.Price;
			productToEdit.Quantity = product.Quantity;
			productToEdit.Image = product.Image;
			productToEdit.IsNew = product.IsNew;
			dbContext.Products.Update(productToEdit);
			dbContext.SaveChanges();
        }
		public async Task DeleteProduct(int id)
		{
			  Product productToDelete =  dbContext.Products.FirstOrDefault(x => x.Id == id);
				productToDelete.IsDeleted = true;
			dbContext.Products.Update(productToDelete);
			dbContext.SaveChanges();
			
		}
    }
}
