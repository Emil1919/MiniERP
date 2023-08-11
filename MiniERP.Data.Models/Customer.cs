using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using MiniERP.Common;

namespace MiniERP.Data.Models
{
	public class Customer
    {
        /// <summary>
        ///     This class describe the customers of the company with reference to the invoices, orders and shipping addresses
        ///     </summary>

        [Comment("Клиенти на дружеството с референция към приходните документи, поръчки и адреси за доставка")]

        [Key]
        public int Id { get; set; }
        [Required]
        public string VatNumber { get; set; } = null!;
        [Required]
        [MaxLength(GeneralConstants.NameMaxLength)]
        public string Name { get; set; } = null!;
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
        public List<Order> Orders { get; set; } = new List<Order>();
        public List<Invoice> Invoices { get; set; } = new List<Invoice>();
        public List<ShipingAdress> ShipingAdresses { get; set; } = new List<ShipingAdress>();

        public decimal TotalTurnover { get; set; }
        public bool IsDeleted { get; set; }









    }
}