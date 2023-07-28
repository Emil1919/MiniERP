using Microsoft.EntityFrameworkCore;
using MiniERP.Common.GeneralConstants;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiniERP.Data.Models
{
    public class ShipingAdress
    {
        [Comment("Адреси за доставка на клиентите на дружеството")]

        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(GeneralConstants.NameMaxLength)]
        public string City { get; set; } = null!;
        [Required]
        [MaxLength(GeneralConstants.NameMaxLength)]
        public string Address { get; set; } = null!;
        [Required]
        [MaxLength(GeneralConstants.NameMaxLength)]
        public string PersonName { get; set; } = null!;

        [MaxLength(GeneralConstants.PhoneNumber)]
        public string PhoneNumber { get; set; } = null!;
        public string? Note { get; set; }

        [Required]
        [ForeignKey(nameof(Customer))]
        public int CustomersId { get; set; }
        Customer Customer { get; set; } = null!;
    }
}