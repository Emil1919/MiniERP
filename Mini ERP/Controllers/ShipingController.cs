using Microsoft.AspNetCore.Mvc;

namespace Mini_ERP.Controllers
{
	public class ShipingController : BaseController
	{
		[HttpGet]
		public IActionResult AddShipingAdress()
		{
			return View();
		}
		public IActionResult EditShipingAddress() { return View(); }
		public IActionResult DeleteShipingAddress() { return View(); }
		public IActionResult AllShipingAddresses() { return View(); }
		public IActionResult ShipingAddressDetails() { return View(); }

	}
}
