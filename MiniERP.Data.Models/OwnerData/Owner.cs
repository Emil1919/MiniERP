using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniERP.Common.GeneralConstants;

namespace MiniERP.Data.Models.OwnerData
{
	public class Owner
	{
		[Key]
		public Guid Id { get; set; }
		[Required]
		[StringLength(GeneralConstants.NameMaxLength)]
		public string Name { get; set; } = null!;
		[Required]
		[StringLength(GeneralConstants.NameMaxLength)]
		public string Address { get; set; } = null!;

		[Required]
		[StringLength(GeneralConstants.BulstatMaxLength)]
		public string Bulstat { get; set; } = null!;
		public string? VatNumber { get; set; }
		[Required]
		[StringLength(GeneralConstants.PhoneNumber)]
		public string PhoneNumber { get; set; } = null!;
		[Required]
		[StringLength(GeneralConstants.EmailMaxLength)]
		public string Email { get; set; } = null!;
		public string? BankAccount { get; set; }
		[Required]
		[StringLength(GeneralConstants.NameMaxLength)]
		public string GeneralManager { get; set; } = null!;

	}
}
