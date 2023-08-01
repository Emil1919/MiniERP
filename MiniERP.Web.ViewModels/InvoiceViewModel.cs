using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP.Web.ViewModels
{
	public class InvoiceViewModel
	{
		
		public int Id { get; set; }
		public string InvoiceNumber { get; set; } = null!;
		public int OrderId { get; set; }
		public int CustomerId { get; set; }
		public List<ProductViewModel> Products { get; set; } = new List<ProductViewModel>();
		public decimal PriceWhitOutVAT { get; set; }
		public decimal TotalPrice { get; set; }
        public bool IsPaid { get; set; }
        public DateTime DateOfInvoice { get; set; }
    }
}
