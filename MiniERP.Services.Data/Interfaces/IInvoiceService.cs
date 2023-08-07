using MiniERP.Web.ViewModels;

namespace MiniERP.Services.Data.Interfaces
{
	public interface IInvoiceService

	{
		
		public Task<bool> IsInvoiceExist(int id);
		public Task<IEnumerable<InvoiceViewModel>> GetAllInvoices();
		public Task <bool> AddInvoice(InvoiceViewModel invoice);
		 public Task<InvoiceViewModel> GetInvoice(int invoiceNumber);
		public Task EditInvoice(InvoiceViewModel invoice);
		public Task DeleteInvoice(InvoiceViewModel invoice);
		
	}
}
