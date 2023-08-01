using Microsoft.EntityFrameworkCore;
using Mini_ERP.Data;
using MiniERP.Services.Data.Interfaces;
using MiniERP.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP.Services.Data
{
	
	public class InvoiceService : IInvoiceService
	{
		private readonly Mini_ERP.Data.MiniERP_DbContext dbContext;
        public InvoiceService(MiniERP_DbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public Task AddInvoice(InvoiceViewModel invoice)
		{
			throw new NotImplementedException();
		}

		public Task DeleteInvoice(InvoiceViewModel invoice)
		{
			throw new NotImplementedException();
		}

		public Task EditInvoice(InvoiceViewModel invoice)
		{
			throw new NotImplementedException();
		}

		public async Task<IEnumerable<InvoiceViewModel>> GetAllInvoices()
		{
			  return await this.dbContext.Invoices.Select(x => new InvoiceViewModel
			{
				Id = x.Id,
				InvoiceNumber = x.InvoiceNumber,
				OrderId = x.OrderId,
				CustomerId = x.CustomerId,
				Products = x.Products.Select(p => new ProductViewModel
				{
					Id = p.Id,
					Name = p.Name,
					Description = p.Description,
					Price = p.Price,
					Quantity = p.Quantity,
					Image = p.Image,
					IsNew = p.IsNew
				}).ToList(),
				PriceWhitOutVAT = x.PriceWhitOutVAT,
				TotalPrice = x.TotalPrice
			}).ToListAsync();
			
			
		}

		public Task<InvoiceViewModel> GetInvoice(int id)
		{
			throw new NotImplementedException();
		}
	}
}
