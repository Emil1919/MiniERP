using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP.Web.ViewModels
{
	// Comment("Информация за поръчката")
	/// <summary>
	/// This class is used to transfer data from the database to the view.
	/// </summary>
	public class OrderViewModel
	{
		public int Id { get; set; }
		public int CustomersId { get; set; }
		public CustomerViewModel Customer { get; set; } = null!;
		public List<ProductViewModel> Products { get; set; } = new List<ProductViewModel>();
		public decimal TotalPrice { get; set; }
		public bool HasInvoice { get; set; }
	}
}
