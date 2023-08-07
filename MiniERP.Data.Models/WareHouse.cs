

namespace MiniERP.Data.Models
{
	public class WareHouse
	{
		public	int Id { get; set; }
		public string Name { get; set; } = null!;
		public string Address { get; set; } = null!;
		public string WareHouseManager { get; set; } = null!;
		public List<Product> Products { get; set; } = null!;

        public OwnerCompany OwnerCompony { get; set; } = null!;



    }
}
