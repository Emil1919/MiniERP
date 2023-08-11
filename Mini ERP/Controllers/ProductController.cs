using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MiniERP.Services.Data.Interfaces;
using MiniERP.Web.ViewModels;

namespace Mini_ERP.Controllers
{
	[Authorize]
	public class ProductController : BaseController
	{
		private readonly IProductService productService;
        public ProductController( IProductService productService)
        {
           this.productService = productService;
        }
		[HttpGet]
        public IActionResult AllProducts()
		{
			IEnumerable<ProductViewModel> products = productService.GetAllProducts().Result;

			return View(products);
		}
		[HttpGet]
		public IActionResult AddProduct()
		{
			ProductViewModel product = new ProductViewModel();

			return View(product);
		}
		[HttpPost]
		public IActionResult AddProduct(ProductViewModel product)
		{
			if (ModelState.IsValid)
			{
				productService.AddProduct(product);
				return RedirectToAction("AllProducts");
			}
			return View(product);
		}
		[HttpGet]
		public IActionResult EditProduct(int id)
		{
			if (productService.Exists(id).Result)
			{
				ProductViewModel product =  productService.GetProduct(id).Result;
				return View(product);
			}
			else
			{
				return RedirectToAction("AllProducts");
			}

			
		}
		[HttpPost]
		public IActionResult EditProduct(ProductViewModel product)
		{
            if (ModelState.IsValid && productService.Exists(product.Id).Result)
			{
                productService.EditProduct(product);
                return RedirectToAction("AllProducts");
            }
            return View(product);
        }
		[HttpGet]
		public async Task <IActionResult>  InfoProduct (int id)
		{
            if (await productService.Exists(id))
			{
                ProductViewModel product = await productService.GetProduct(id);
                return  View(product);
            }
            else
			{
                return RedirectToAction("AllProducts");
            }
        }
		[HttpGet]
		public IActionResult DeleteProduct(int id)
		{
			if (productService.Exists(id).Result)
			{
				productService.DeleteProduct(id);
				return RedirectToAction("AllProducts");
			}
			else
			{
				return RedirectToAction("AllProducts");
			}
		}

	}
}
