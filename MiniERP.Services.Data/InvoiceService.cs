using Microsoft.EntityFrameworkCore;
using Mini_ERP.Data;
using MiniERP.Data.Models;
using MiniERP.Services.Data.Interfaces;
using MiniERP.Web.ViewModels;


namespace MiniERP.Services.Data
{
	
	// Coment: This class is used to create, edit and delete invoices.
	/// <summary>
	/// This class is used to create, edit and delete invoices.
	/// </summary>
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
				editedInvoice.DateOfInvoice = DateTime.Now;
				
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

        
		public Task<bool> AddInvoice(InvoiceViewModel invoice)
		{
			int lastInvoiceNumber = dbContext.Invoices.Max(x => x.InvoiceNumber);

			Invoice newInvoice = new Invoice
			{
				InvoiceNumber = ++lastInvoiceNumber,
				OrderId = invoice.OrderId,
				CustomerId = invoice.CustomerId,
				PriceWhitOutVAT = invoice.PriceWhitOutVAT,
				TotalPrice = invoice.TotalPrice,
				IsPaid = invoice.IsPaid,
				DateOfInvoice = DateTime.Now
			};
			dbContext.Invoices.Add(newInvoice);
			dbContext.SaveChanges();
			return Task.FromResult(true);
		}
	}
}
