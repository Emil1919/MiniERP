using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MiniERP.Services.Data.Interfaces;
using MiniERP.Web.ViewModels;

namespace Mini_ERP.Controllers
{
	[Authorize]
	public class ProductController : BaseController
	{
		private readonly IProductService _productService;
        public ProductController( IProductService productService)
        {
           _productService = productService;
        }
		[HttpGet]
        public IActionResult AllProducts()
		{
			IEnumerable<ProductViewModel> products = _productService.GetAllProducts().Result;

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
				_productService.AddProduct(product);
				return RedirectToAction("AllProducts");
			}
			return View(product);
		}
		[HttpGet]
		public IActionResult EditProduct(int id)
		{
			if (_productService.Exists(id).Result)
			{
				ProductViewModel product =  _productService.GetProduct(id).Result;
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
            if (ModelState.IsValid && _productService.Exists(product.Id).Result)
			{
                _productService.EditProduct(product);
                return RedirectToAction("AllProducts");
            }
            return View(product);
        }
		[HttpGet]
		public async Task <IActionResult>  InfoProduct (int id)
		{
            if (await _productService.Exists(id))
			{
                ProductViewModel product = await _productService.GetProduct(id);
                return  View(product);
            }
            else
			{
                return RedirectToAction("AllProducts");
            }
        }

	}
}
