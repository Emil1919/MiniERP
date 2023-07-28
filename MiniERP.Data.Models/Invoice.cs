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
        public string InvoiceNumber { get; set; } = null!;
        [Required]
        [ForeignKey(nameof(Order))]
        public int OrderId { get; set; }
        public Order Order { get; set; } = null!;
        [Required]
        [ForeignKey(nameof(Customer))]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;
        public List<Product> Products { get; set; } = new List<Product>();

        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }
    }
}