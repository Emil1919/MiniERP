
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MiniERP.Common.GeneralConstants;

namespace MiniERP.Data.Models
{
    public class OwnerCompany
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [StringLength(GeneralConstants.NameMaxLength)]
        public string CompanyName { get; set; } = null!;
        [Required]
        [StringLength(GeneralConstants.NameMaxLength)]
        public string Address { get; set; } = null!;

        [Required]
        [StringLength(GeneralConstants.BulstatMaxLength)]
        public string Bulstat { get; set; } = null!;
        public string? VatNumber { get; set; }
        [Required]
        [StringLength(GeneralConstants.PhoneNumber)]
        public string PhoneNumber { get; set; } = null!;
        [Required]
        [StringLength(GeneralConstants.EmailMaxLength)]
        public string Email { get; set; } = null!;
        public string? BankAccount { get; set; }
        [Required]
        [StringLength(GeneralConstants.NameMaxLength)]
        public string GeneralManager { get; set; } = null!;

        [ForeignKey(nameof(OwnerCompany))]
        public int WareHouseId { get; set; }
        public List<WareHouse> WareHouses { get; set; } = null!;

    }
}
