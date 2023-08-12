
using System.ComponentModel.DataAnnotations;
using MiniERP.Common;

namespace MiniERP.Web.ViewModels
{
	// Comment("Информация за продукта")
	/// <summary>
	/// This class is used to transfer data from the controller to the view.
	/// </summary>
	public class ProductViewModel
	{
		public int Id { get; set; }
		[Required]
		[MaxLength(GeneralConstants.NameMaxLength)]
		[Display(Name = "Name")]
		[MinLength(GeneralConstants.NameMinLength)]
		public string Name { get; set; } = null!;


		[MaxLength(GeneralConstants.NameMaxLength)]
		[MinLength(GeneralConstants.NameMinLength)]
		[Required]
		public string Description { get; set; }= null!;
		[Range(0.1, Double.MaxValue, ErrorMessage = "The field {0} must be greater than {1}$")]
		public decimal Price { get; set; }
		[Range(0, int.MaxValue, ErrorMessage = "The quantity {0} must be greater than {1} psc")]
		public int Quantity { get; set; }

		[MaxLength(GeneralConstants.URL_MaxLenght)]
		[MinLength(GeneralConstants.URL_MinLenght)]
		[Required]
		public string? Image { get; set; }

        public bool IsNew { get; set; }
		public bool IsDeleted { get; set; }



    }
}
