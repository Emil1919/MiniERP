
using System.ComponentModel.DataAnnotations;
using MiniERP.Common;

namespace MiniERP.Web.ViewModels
{
	// Comment("Информация за фирмата собственик")
	/// <summary>
	/// This class is used to transfer data from the controller to the view.
	/// </summary>
	public class OwnerCompanyViewModel
	{
		public Guid Id { get; set; }
		[Required]
		[StringLength(GeneralConstants.NameMaxLength)]
		public string CompanyName { get; set; } = null!;
		[Required]
		[StringLength(GeneralConstants.NameMaxLength)]
		public string Address { get; set; } = null!;

		[Required]
		[MinLength(GeneralConstants.BulstatMinLength)]
		[MaxLength(GeneralConstants.BulstatMaxLength)]
		public string Bulstat { get; set; } = null!;
		public string? VatNumber { get; set; }
		[Required]
		[StringLength(GeneralConstants.PhoneNumber)]
		public string PhoneNumber { get; set; } = null!;
		[Required]
		[StringLength(GeneralConstants.EmailMaxLength)]
		[MinLength(GeneralConstants.EmailMinLenght)]
		public string Email { get; set; } = null!;
		public string? BankAccount { get; set; }
		[Required]
		[StringLength(GeneralConstants.NameMaxLength)]
		[MinLength(GeneralConstants.NameMinLength)]
		public string GeneralManager { get; set; } = null!;

	}
}
