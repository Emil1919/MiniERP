using MiniERP.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP.Services.Data.Interfaces
{
	public interface IInvoiceService

	{
		
		Task<IEnumerable<InvoiceViewModel>> GetAllInvoices();
		Task <bool> AddInvoice(InvoiceViewModel invoice);
		//	Task<InvoiceViewModel> GetInvoice(int id);
		//	Task EditInvoice(InvoiceViewModel invoice);
		//	Task DeleteInvoice(InvoiceViewModel invoice);
		
	}
}
