using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP.Web.ViewModels
{
	public class OrderViewModel
	{
		public int Id { get; set; }
		public int CustomersId { get; set; }
		public CustomerViewModel Customer { get; set; } = null!;
		public List<ProductViewModel> Products { get; set; } = new List<ProductViewModel>();
	}
}
