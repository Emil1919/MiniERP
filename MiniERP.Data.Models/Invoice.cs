using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiniERP.Data.Models
{
    [Comment("Фактури на клиентите на дружеството")]
    public class Invoice
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int InvoiceNumber { get; set; } 
        [Required]
        public int OrderId { get; set; }
        [Required]
        public int CustomerId { get; set; }
		[Required]
		public decimal PriceWhitOutVAT { get; set; }
		[Required]
		public decimal TotalPrice { get; set; }
		[Required]
		public bool IsPaid { get; set; }
        public DateTime DateOfInvoice { get; set; }
    }
}