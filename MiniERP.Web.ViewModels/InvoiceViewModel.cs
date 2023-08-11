
using System.ComponentModel.DataAnnotations;


namespace MiniERP.Web.ViewModels
{
	// Comment("Информация за фактурата")

	/// <summary>
	/// This class is used to transfer data from the controller to the view.
	/// </summary>
	public class InvoiceViewModel
	{
		
		
		public int Id { get; set; }
		public int InvoiceNumber { get; set; }
		[Required]
		public string CustomerName { get; set; } = null!;
		[Required]
		public int OrderId { get; set; }
		[Required]
		public int CustomerId { get; set; }
		public List<ProductViewModel> Products { get; set; } = new List<ProductViewModel>();
		public decimal PriceWhitOutVAT { get; set; }
		[Required]
		public decimal TotalPrice { get; set; }
        public bool IsPaid { get; set; }
        public DateTime DateOfInvoice { get; set; }
    }
}
