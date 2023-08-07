using MiniERP.Common;

using System.ComponentModel.DataAnnotations;

/// <summary>
/// This class is used to represent the data for the shiping address form.
/// /// </summary>

namespace MiniERP.Web.ViewModels.ShipngViewModels
{
	public class ShipingAdressFormViewModel
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


		public HashSet<string> Clients { get; set; } = new HashSet<string>();
	}
}
