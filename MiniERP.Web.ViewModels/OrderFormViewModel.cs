using MiniERP.Web.ViewModels.ShipngViewModels;


namespace MiniERP.Web.ViewModels
{
	public class OrderFormViewModel
	{
		public HashSet<CustomerViewModel> Customers=new HashSet<CustomerViewModel>();
		public List<ProductViewModel> Products=new List<ProductViewModel>();
		public HashSet<ShipingAddressViewModel> ShipingAddressViewModels=new HashSet<ShipingAddressViewModel>();
        public int SelectedClientId { get; set; }
        public List<ProductViewModel> SelectedProducts { get; set; }=new List<ProductViewModel>();
        public decimal TotalPriceWhitVat { get; set; }
	}
}
