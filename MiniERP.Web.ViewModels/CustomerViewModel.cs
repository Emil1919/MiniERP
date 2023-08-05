
using MiniERP.Common.GeneralConstants;
using System.ComponentModel.DataAnnotations;

namespace MiniERP.Web.ViewModels
{
    public class CustomerViewModel
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(GeneralConstants.NameMaxLength)]

        public string Name { get; set; } = null!;
        [Required]
        public string VatNumber { get; set; } = null!;
		[Required]
        [MaxLength(GeneralConstants.NameMaxLength)]
        public string City { get; set; } = null!;
        [Required]
        [MaxLength(GeneralConstants.NameMaxLength)]
        public string Address { get; set; } = null!;
        [Required]
        [MaxLength(GeneralConstants.NameMaxLength)]
        public string Manager { get; set; } = null!;

        [MaxLength(GeneralConstants.PhoneNumber)]
        public string PhoneNumber { get; set; } = null!;
    }
}
