using Mini_ERP.Data;
using MiniERP.Data.Models;
using MiniERP.Services.Tests.Mocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP.Services.Tests.UnitTests
{
	public class UnitTestBase
	{
		protected MiniERP_DbContext data;

		[OneTimeSetUp]
		public void SetUpBase()
		{
			data = DatabaseMock.Instance;
			SeedDatabase();
		}
		public OwnerCompany MyCompany { get; private set; }
		public Customer CustomerOfMycompany { get; private set; }
		public Product ProductOfMyCompany { get; private set; }
		public Order OrderFromCompany { get; private set; }
		public Invoice InvoiceFromMyCompany { get; private set; }

		public void SeedDatabase()
		{
			MyCompany = new OwnerCompany
			{
				Id = 1,
				CompanyName = "MyCompany",
				Address = "MyAddress",
				Bulstat = "MyBulstat",
				VatNumber = "MyVatNumber",
				PhoneNumber = "MyPhoneNumber",
				Email = "MyEmail",
				BankAccount = "MyBankAccount",
				GeneralManager = "MyGeneralManager",
				Balance = 0
			};
			data.OwnerCompanie.Add(MyCompany);
			CustomerOfMycompany = new Customer
			{
				Id = 1,
				Name = "CustomerOfMycompany",
				Address = "CustomerOfMycompanyAddress",
				VatNumber = "CustomerOfMycompanyVatNumber",
				PhoneNumber = "CustomerOfMycompanyPhoneNumber",
				TotalTurnover = 0,
				IsDeleted = false
				
			};
			ProductOfMyCompany = new Product
			{
				Id = 1,
				Name = "ProductOfMyCompany",
				Price = 10,
				Quantity = 10,
				IsDeleted = false,
				IsNew = false
			};
			OrderFromCompany = new Order
			{
				Id = 1,
				HasInvoice = false,
				CustomersId = 1,
				Customer = CustomerOfMycompany,
				IsDeleted = false

			};
			InvoiceFromMyCompany = new Invoice
			{
				Id = 1,
				OrderId = 1,
				Order = OrderFromCompany,
				IsDeleted = false,
				TotalPrice = 1000,
				CustomerId = 1,
				IsPaid = false,
				
			};
		}

		[OneTimeTearDown]
		public void TearDownBase()
		=> data.Dispose();
	}
	
}
