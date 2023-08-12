using MiniERP.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP.Web.ViewModels
{
	public class OwnerViewModel

	{
		public string CompanyName { get; set; } = null!;
		
		public string Address { get; set; } = null!;

		
		public string Bulstat { get; set; } = null!;
		public string? VatNumber { get; set; }
		
		public string PhoneNumber { get; set; } = null!;
		
		public string Email { get; set; } = null!;
		public string? BankAccount { get; set; }
		
		public string GeneralManager { get; set; } = null!;

		public string WareHouseName { get; set; } = null!;
		public decimal WareHouseTotalValue { get; set; } 
		public decimal Balance { get; set; }
		public int TotalProducts { get; set; }
		public int TotalCustomers { get; set; }
		public int TotalOrders { get; set; }
		public int TotalInvoices { get; set; }

	}
}
