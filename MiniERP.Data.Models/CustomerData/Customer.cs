using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using MiniERP.Common.GeneralConstants;

namespace MiniERP.Data.Models.CustomerData
{
    public class Customer
    {
        [Comment("Клиенти на дружеството с референция към приходните документи, поръчки и адреси за доставка")]

        [Key]
        public int Id { get; set; }
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



        List<Invoice> Invoices { get; set; } = new List<Invoice>();
        List<Order> Orders { get; set; } = new List<Order>();
        List<ShipingAdress> ShipingAdresses { get; set; } = new List<ShipingAdress>();



    }
}