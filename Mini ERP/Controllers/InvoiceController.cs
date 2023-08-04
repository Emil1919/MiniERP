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
		[HttpGet]
		public IActionResult AddInvoice()
		{
			InvoiceViewModel invoice = new InvoiceViewModel();
			return View(invoice);
		}
		[HttpPost]
		public IActionResult AddInvoice(InvoiceViewModel invoice)
		{
			if (ModelState.IsValid)
			{
				invoiceService.AddInvoice(invoice);
				return RedirectToAction("AllInvoices");
			}
			return View(invoice);
		}
		//[HttpGet]
		//public IActionResult EditInvoice(int id)
		//{
		//	InvoiceViewModel invoice = _invoiceService.GetInvoice(id);
		//	return View(invoice);
		//}
		//[HttpPost]
		//public IActionResult EditInvoice(InvoiceViewModel invoice)
		//{
		//	if (ModelState.IsValid)
		//	{
		//		_invoiceService.EditInvoice(invoice);
		//		return RedirectToAction("AllInvoices");
		//	}
		//	return View(invoice);
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

