using Microsoft.AspNetCore.Mvc;
using MiniERP.Services.Data.Interfaces;
using MiniERP.Web.ViewModels;

namespace Mini_ERP.Controllers
{
	public class CustomerController : BaseController
	{
        private readonly ICustomerService customerService;
        public CustomerController(ICustomerService customerService)
        {
            this.customerService = customerService;
        }
        [HttpGet]
        public IActionResult AllCustomers()
        {
            IEnumerable<CustomerViewModel> customers = customerService.GetAll().Result;
            
            return View(customers);
        }
        [HttpGet]
        public IActionResult CreateCustomer()
        {
            CustomerViewModel customer = new CustomerViewModel();
            return View(customer);
        }

        [HttpPost]
        public IActionResult CreateCustomer(CustomerViewModel customer)
        {
            if (ModelState.IsValid)
            {
                customerService.Create(customer);
                return RedirectToAction("AllCustomers");
            }
            return View(customer);
        }
        [HttpGet]
        public IActionResult EditCustomer(int id)
        {
			if (!customerService.IsExist(id).Result)
            {
				return RedirectToAction("AllCustomers");
			}
			CustomerViewModel customer = customerService.GetById(id).Result;
			return View(customer);
		}
		[HttpPost]
		public IActionResult EditCustomer(CustomerViewModel customer)
		{
			if (ModelState.IsValid)
			{
				customerService.Edit(customer);
				return RedirectToAction("AllCustomers");
			}
			return View(customer);
		}
		[HttpGet]
        public IActionResult DeleteCustomer(int id)
        {
            
                customerService.Delete(id);
				return RedirectToAction("AllCustomers");

        }

     
        
    }
}
