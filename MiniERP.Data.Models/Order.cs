using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiniERP.Data.Models
{
    /// <summary>
    /// This class describe the orders of the company
    /// </summary>

    [Comment("Поръчки на клиентите на дружеството")]
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(Customer))]
        public int CustomersId { get; set; }
        public Customer Customer { get; set; } = null!;
        public Invoice? Invoice { get; set; } = null!;
        
        public List<Product> Products { get; set; } = new List<Product>();
        public bool IsDeleted { get; set; }
        public decimal TotalPrice { get; set; }
    }
}