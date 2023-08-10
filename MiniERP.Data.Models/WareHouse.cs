

using Microsoft.EntityFrameworkCore;
using MiniERP.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiniERP.Data.Models
{
	/// <summary>
	/// This class describe the warehouse of the company
	/// </summary>
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
		
		[ForeignKey(nameof(OwnerCompany))]
		public int OwnerCompanyId { get; set; }

        public OwnerCompany OwnerCompany { get; set; } = null!;



    }
}
