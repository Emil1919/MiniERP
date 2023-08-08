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
	// Comment("Информация за склада")

	/// <summary>
	/// This class is used to transfer data from the controller to the view.
	/// </summary>
	public class WareHouseViewModel
	{
		
		[Required]
		[MaxLength(GeneralConstants.NameMaxLength)]
		[MinLength(GeneralConstants.NameMinLength)]
		public string Name { get; set; } = null!;
		[Required]
		[MaxLength(GeneralConstants.NameMaxLength)]
		[MinLength(GeneralConstants.NameMinLength)]

		public string Address { get; set; } = null!;
		[Required]
		[MaxLength(GeneralConstants.NameMaxLength)]
		[MinLength(GeneralConstants.NameMinLength)]

		public string WareHouseManager { get; set; } = null!;
		
		public List<ProductViewModel> Products { get; set; } = new List<ProductViewModel>();

		
	}
}
