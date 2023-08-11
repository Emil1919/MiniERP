using Microsoft.AspNetCore.Mvc;
using MiniERP.Services.Data.Interfaces;
using MiniERP.Web.ViewModels;

namespace Mini_ERP.Controllers
{

	public class InvoiceController : BaseController
	{
		private readonly IInvoiceService invoiceService;

		public InvoiceController(IInvoiceService invoiceService)
		{
			this.invoiceService = invoiceService;


		}


		public async Task<IActionResult> AllInvoices()
		{
			IEnumerable<InvoiceViewModel> invoices = await invoiceService.GetAllInvoices();
			return View(invoices);
		}

		// Use OrderId to create Invoice
		public IActionResult AddInvoice(int id)
		{


			if (invoiceService.AddInvoice(id).Result == true)
			{
				return RedirectToAction("AllInvoices");
			}
			return RedirectToAction("AllOrders","Order");

		}
		[HttpGet]
		public IActionResult EditInvoice(int id)
		{
			if (!invoiceService.IsInvoiceExist(id).Result)
			{
				return RedirectToAction("AllInvoices");
			}
			InvoiceViewModel invoice = invoiceService.GetInvoice(id).Result;
			return View(invoice);
		}
		[HttpPost]
		public IActionResult EditInvoice(InvoiceViewModel invoice)
		{
			if (ModelState.IsValid)
			{
				invoiceService.EditInvoice(invoice);
				return RedirectToAction("AllInvoices");
			}
			return View(invoice);
		}


		
		public IActionResult PayInvoice(int id)
		{
			invoiceService.PayInvoice(id);
			return RedirectToAction("AllInvoices");
		}

		//[HttpPost]
		//public IActionResult PayInvoice(int invoiceId)
		//{
		//	invoiceService.PayInvoice(invoiceId);
		//	return RedirectToAction("AllInvoices");
		//}


		//[HttpGet]
		//public IActionResult DeleteInvoice(int id)
		//{
		//	InvoiceViewModel invoice = _invoiceService.GetInvoice(id);
		//	return View(invoice);
		//}
		//[HttpPost]
		//public IActionResult DeleteInvoice(InvoiceViewModel invoice)
		//{
		//	_invoiceService.DeleteInvoice(invoice);
		//	return RedirectToAction("AllInvoices");
		//}
		//[HttpGet]
		//public IActionResult InvoiceDetails(int id)
		//{
		//	InvoiceViewModel invoice = _invoiceService.GetInvoice(id);
		//	return View(invoice);
		//}
		//[HttpGet]
		//public IActionResult PrintInvoice(int id)
		//{
		//	InvoiceViewModel invoice = _invoiceService.GetInvoice(id);
		//	return View(invoice);
		//}

		//return View();
	}
}

