using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MiniERP.Services.Data.Interfaces;
using MiniERP.Web.ViewModels;

namespace Mini_ERP.Controllers
{
	[Authorize]
	public class ProductController : Controller
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
	}
}
