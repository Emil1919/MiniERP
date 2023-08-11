using Microsoft.EntityFrameworkCore;
using MiniERP.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiniERP.Data.Models
{
	[Comment("Продукти на дружеството")]

    /// <summary>
    /// This class describe the products of the company
    /// </summary>
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

        public bool IsDeleted { get; set; }


        

    }
}