
using MiniERP.Common;
using System.ComponentModel.DataAnnotations;

namespace MiniERP.Web.ViewModels
{
    // Comment("Информация за клиента")
    /// <summary>
    ///   This  class is used to transfer data from the controller to the view.
    ///   </summary>
    
	public class CustomerViewModel
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(GeneralConstants.NameMaxLength)]
        [MinLength(GeneralConstants.NameMinLength)]

        public string Name { get; set; } = null!;
        [Required]
        [MaxLength(GeneralConstants.BulstatMaxLength)]
        [MinLength(GeneralConstants.BulstatMinLength)]
        public string VatNumber { get; set; } = null!;
		[Required]
        [MaxLength(GeneralConstants.NameMaxLength)]
        [MinLength(GeneralConstants.NameMinLength)]
        public string City { get; set; } = null!;
        [Required]
        [MaxLength(GeneralConstants.AddressMaxLength)]
        [MinLength(GeneralConstants.AddressMinLength)]
        public string Address { get; set; } = null!;
        [Required]
        [MaxLength(GeneralConstants.NameMaxLength)]
        [MinLength(GeneralConstants.NameMinLength)]
        public string Manager { get; set; } = null!;

        [MaxLength(GeneralConstants.PhoneNumberMax)]
        [MinLength(GeneralConstants.PhoneNumberMin)]
        [Required]
        public string PhoneNumber { get; set; } = null!;
        public decimal Turnover { get; set; }

		public decimal TotalTurnover { get; set; }
	}
}
