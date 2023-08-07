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
		public int Id { get; set; }
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
		
		public Guid OwnerComponyId { get; set; }

		
	}
}
