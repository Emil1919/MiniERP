﻿

using Microsoft.EntityFrameworkCore;
using MiniERP.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiniERP.Data.Models
{
	public class WareHouse
	{
		[Comment("Информация за склада")]
		[Key]
		public	int Id { get; set; }
		[Required]
		[MaxLength(GeneralConstants.NameMaxLength)]
		public string Name { get; set; } = null!;
		[Required]
		[MaxLength(GeneralConstants.NameMaxLength)]

		public string Address { get; set; } = null!;
		[Required]
		[MaxLength(GeneralConstants.NameMaxLength)]

		public string WareHouseManager { get; set; } = null!;
		public List<Product> Products { get; set; } = null!;
		[ForeignKey(nameof(OwnerCompony))]
		public Guid OwnerComponyId { get; set; }

        public OwnerCompany OwnerCompony { get; set; } = null!;



    }
}
