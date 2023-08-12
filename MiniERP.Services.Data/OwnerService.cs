using Mini_ERP.Data;
using MiniERP.Data.Models;
using MiniERP.Services.Data.Interfaces;
using MiniERP.Web.ViewModels;


namespace MiniERP.Services.Data
{
	public class OwnerService : IOwnerService
	{
		MiniERP_DbContext dbContext;
		public OwnerService( MiniERP_DbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public Task<OwnerViewModel> GetInfo()
		{
			
			OwnerViewModel ownerViewModel = new OwnerViewModel();
			OwnerCompany ownerCompany= dbContext.Companies.FirstOrDefault();
			ownerViewModel.CompanyName = ownerCompany.CompanyName;
			ownerViewModel.Address = ownerCompany.Address;
			ownerViewModel.Bulstat = ownerCompany.Bulstat;
			ownerViewModel.VatNumber = ownerCompany.VatNumber;
			ownerViewModel.PhoneNumber = ownerCompany.PhoneNumber;
			ownerViewModel.Email = ownerCompany.Email;
			ownerViewModel.BankAccount = ownerCompany.BankAccount;
			ownerViewModel.GeneralManager = ownerCompany.GeneralManager;
			ownerViewModel.Balance = ownerCompany.Balance;
			ownerViewModel.TotalCustomers = dbContext.Customers.Count();
			ownerViewModel.TotalInvoices = dbContext.Invoices.Count();
			ownerViewModel.TotalOrders = dbContext.Orders.Count();
			ownerViewModel.TotalProducts = CountOfAllProducts().Result;
			ownerViewModel.WareHouseName = dbContext.WareHouses.FirstOrDefault().Name;
			ownerViewModel.WareHouseTotalValue = TotalPriceOfAllProducts().Result;
			
			


			return Task.FromResult(ownerViewModel);
		}
		public Task<decimal> TotalPriceOfAllProducts()
		{
			decimal countOfAllProducts = 0;
			foreach (var product in dbContext.Products)
			{
				countOfAllProducts += (product.Quantity*product.Price);
			}
			
			return Task.FromResult(countOfAllProducts);
		}
		public Task<int> CountOfAllProducts()
		{
			int countOfAllProducts = 0;
			foreach (var product in dbContext.Products)
			{
				countOfAllProducts += product.Quantity;
			}

			return Task.FromResult(countOfAllProducts);
		}
	}
}
