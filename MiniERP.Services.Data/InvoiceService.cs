using Microsoft.EntityFrameworkCore;
using Mini_ERP.Data;
using MiniERP.Data.Models;
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
		private readonly MiniERP_DbContext dbContext;
        public InvoiceService(MiniERP_DbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        

		public Task DeleteInvoice(InvoiceViewModel invoice)
		{
			throw new NotImplementedException();
		}

		public Task EditInvoice(InvoiceViewModel invoice)
		{
			
			
				Invoice editedInvoice = dbContext.Invoices.FirstOrDefaultAsync(x => x.InvoiceNumber == invoice.InvoiceNumber).Result;
				editedInvoice.CustomerId = invoice.CustomerId;
				editedInvoice.OrderId = invoice.OrderId;
				editedInvoice.TotalPrice = invoice.TotalPrice;
				
				dbContext.Invoices.Update(editedInvoice);
				dbContext.SaveChanges();
			
			return Task.CompletedTask;

			
		}

		public async Task<IEnumerable<InvoiceViewModel>> GetAllInvoices()
		{
			  return await this.dbContext.Invoices.Select(x => new InvoiceViewModel
			{
				
				InvoiceNumber = x.InvoiceNumber,
				OrderId = x.OrderId,
				CustomerId = x.CustomerId,
				PriceWhitOutVAT = x.PriceWhitOutVAT,
				TotalPrice = x.TotalPrice,
				IsPaid = x.IsPaid,
				DateOfInvoice = x.DateOfInvoice
				

			}).ToListAsync();
			
			
		}

		public async Task<InvoiceViewModel> GetInvoice(int invoiceNumber)
		{
			InvoiceViewModel thisInvoice= await dbContext.Invoices.FirstOrDefaultAsync(x => x.InvoiceNumber == invoiceNumber).ContinueWith(x => new InvoiceViewModel
			{
                
                InvoiceNumber = x.Result.InvoiceNumber,
                OrderId = x.Result.OrderId,
                CustomerId = x.Result.CustomerId,
                PriceWhitOutVAT = x.Result.PriceWhitOutVAT,
                TotalPrice = x.Result.TotalPrice,
                IsPaid = x.Result.IsPaid,
                DateOfInvoice = x.Result.DateOfInvoice
            });
			return thisInvoice;
		}

        public async Task<bool> IsInvoiceExist(int id)
        {
           return await this.dbContext.Invoices.AnyAsync(x => x.InvoiceNumber == id);
        }

        async Task<bool> IInvoiceService.AddInvoice(InvoiceViewModel invoice)
		{
			if (invoice == null)
			{
				return await Task.FromResult(false);
			}
			else
			{
				int lastInvoiceNumber=0;
				if (this.dbContext.Invoices.FirstOrDefault()!=null)
				{
					lastInvoiceNumber = await this.dbContext.Invoices.MaxAsync(x => x.InvoiceNumber);
				}
				

				Invoice newInvoice = new Invoice
				{
					
					InvoiceNumber = lastInvoiceNumber+1,
					CustomerId = invoice.CustomerId,
					OrderId = invoice.OrderId,
					TotalPrice = invoice.TotalPrice,
					IsPaid = false,
					DateOfInvoice = DateTime.Now,
					PriceWhitOutVAT =  invoice.TotalPrice,
					
					

				};
				
				this.dbContext.Invoices.Add(newInvoice);
				this.dbContext.SaveChanges();
				return await Task.FromResult(true);
			}
		}
	}
}
