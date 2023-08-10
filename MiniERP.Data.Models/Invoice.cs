using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiniERP.Data.Models
{
    /// <summary>
    /// This class describe the invoices of the company
    /// </summary>
    [Comment("Фактури на клиентите на дружеството")]
    public class Invoice
    {
        [Key]
        public int Id { get; set; }
        [Required]

        public int InvoiceNumber { get; set; } 

        [Required]
		[ForeignKey(nameof(Order))]
		public int OrderId { get; set; }
        
        public Order Order { get; set; } = null!;


        
        [ForeignKey(nameof(Customer))]
        public int CustomerId { get; set; }

        public Customer Customer { get; set; }=null!;


		[Required]
		public decimal PriceWhitOutVAT { get; set; }
		[Required]
		public decimal TotalPrice { get; set; }
		[Required]
		public bool IsPaid { get; set; }
        public DateTime DateOfInvoice { get; set; }

        
        
    }
}