using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace MiniERP.Data.Models.CustomerData
{
	[Comment("Типове на единици за продажба")]
	public class TypeOfUnit
	{
		[Key]
		public int Id { get; set; }
		[Required]
		[MaxLength(10)]
        public string? TupeOfUnit { get; set; }
    }
}