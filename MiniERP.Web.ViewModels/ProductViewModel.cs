﻿
using System.ComponentModel.DataAnnotations;
using MiniERP.Common.GeneralConstants;

namespace MiniERP.Web.ViewModels
{
	public class ProductViewModel
	{
		public int Id { get; set; }
		[Required]
		[MaxLength(GeneralConstants.NameMaxLength)]
		[Display(Name = "Име")]
		[MinLength(GeneralConstants.NameMinLength)]
		public string Name { get; set; } = null!;

		[MaxLength(GeneralConstants.NameMaxLength)]
		public string? Description { get; set; }
		public decimal Price { get; set; }
		public int Quantity { get; set; }

		[MaxLength(GeneralConstants.URL_MaxLenght)]
		public string? Image { get; set; }

        public bool IsNew { get; set; }



    }
}
