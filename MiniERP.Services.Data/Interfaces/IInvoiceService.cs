using MiniERP.Web.ViewModels;

namespace MiniERP.Services.Data.Interfaces
{
	/// <summary>
	///  This interface is used for the InvoiceService
	/// </summary>
	public interface IInvoiceService

	{
		
		public Task<bool> IsInvoiceExist(int id);
		public Task<IEnumerable<InvoiceViewModel>> GetAllInvoices();
		public Task <bool> AddInvoice(int orderId);
		public Task<InvoiceViewModel> GetInvoice(int invoiceNumber);
		public Task EditInvoice(InvoiceViewModel invoice);
		public Task DeleteInvoice(InvoiceViewModel invoice);
		public Task PayInvoice(int invoiceId);
		
	}
}
