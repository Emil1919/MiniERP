using Microsoft.EntityFrameworkCore;
using MiniERP.Common.GeneralConstants;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiniERP.Data.Models
{
    [Comment("Продукти на дружеството")]
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(GeneralConstants.NameMaxLength)]
        public string Name { get; set; } = null!;

        [MaxLength(GeneralConstants.NameMaxLength)]
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
		public bool IsNew { get; set; }


		[MaxLength(GeneralConstants.URL_MaxLenght)]
        public string? Image { get; set; }

        public int OrderId { get; set; }
        [ForeignKey(nameof(OrderId))]
        public List<Order> OrderedProducts { get; set; } = new List<Order>();

    }
}