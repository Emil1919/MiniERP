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
	// Comment("Информация за адреса на доставката")
	public class ShipingAddressViewModel
	{
		public int Id { get; set; }
		[Required]
		[MaxLength(GeneralConstants.NameMaxLength)]
		[MinLength(GeneralConstants.NameMinLength)]
		public string City { get; set; } = null!;
		[Required]
		[MaxLength(GeneralConstants.NameMaxLength)]
		[MinLength(GeneralConstants.NameMinLength)]
		public string Address { get; set; } = null!;
		[Required]
		[MaxLength(GeneralConstants.NameMaxLength)]
		[MinLength(GeneralConstants.NameMinLength)]
		public string PersonName { get; set; } = null!;

		[MaxLength(GeneralConstants.PhoneNumber)]
		[Phone]
		public string PhoneNumber { get; set; } = null!;
		public string? Note { get; set; }

		[Required]
		public int CustomersId { get; set; }
		
	}
}
