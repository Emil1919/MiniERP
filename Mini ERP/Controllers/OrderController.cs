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
		public IActionResult AddOrder()
		{
			return View();
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
