﻿
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
		public string? Description { get; set; }
		public decimal Price { get; set; }
		public int Quantity { get; set; }

		[MaxLength(GeneralConstants.URL_MaxLenght)]
		public string? Image { get; set; }

        public bool IsNew { get; set; }
		public bool IsDeleted { get; set; }



    }
}
