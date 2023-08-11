using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mini_ERP.Data;
using MiniERP.Services.Data.Interfaces;
using MiniERP.Web.ViewModels;
using System.Security.AccessControl;

namespace Mini_ERP.Controllers
{
	public class OrderController : BaseController
	{
		private readonly IOrderService orderService;
        public OrderController(IOrderService orderService)
        {
            this.orderService = orderService;
        }


        public IActionResult AllOrders()
		{
			IEnumerable<OrderViewModel> orders =  orderService.GetAllOrders().Result;
			return View(orders);
		}
		[HttpGet]
		public IActionResult AddOrder()
		{
			OrderFormViewModel orderFormViewModel = orderService.GetOrderForm().Result;
			return View(orderFormViewModel);
		}
		[HttpPost]
		public async Task<IActionResult> AddOrder(OrderFormViewModel orderFormViewModel)
		{
			
			
				bool isAddedOrder=await orderService.AddOrder(orderFormViewModel);
				if ( isAddedOrder == true)
				{ 
				return RedirectToAction("AllOrders");
				}
				else
				{
					// da se dobavi error message
					return View("ErrorInOrder");
				}
			
			
		}
		public IActionResult EditOrder()
		{
			return View();
		}
		public IActionResult DeleteOrder()
		{
			return View();
		}
		
	}
}
