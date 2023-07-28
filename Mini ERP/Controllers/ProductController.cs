using Microsoft.AspNetCore.Mvc;
using MiniERP.Services.Data.Interfaces;
using MiniERP.Web.ViewModels;

namespace Mini_ERP.Controllers
{
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
			var products =  _productService.GetAllProducts();

			return View(products);
		}
	}
}
