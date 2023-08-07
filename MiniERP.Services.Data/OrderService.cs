using Mini_ERP.Data;
using MiniERP.Data.Models;
using MiniERP.Services.Data.Interfaces;
using MiniERP.Web.ViewModels;


namespace MiniERP.Services.Data
{
	
	public class OrderService : IOrderService
	{
		MiniERP_DbContext dbContext;
        public OrderService(MiniERP_DbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public Task<bool> AddOrder(OrderViewModel order)
		{
			throw new NotImplementedException();
		}

		public Task DeleteOrder(OrderViewModel order)
		{
			throw new NotImplementedException();
		}

		public Task EditOrder(OrderViewModel order)
		{
			throw new NotImplementedException();
		}

		public async Task<IEnumerable<OrderViewModel>> GetAllOrders()
		{
			IEnumerable<OrderViewModel> orderViewModels = dbContext.Orders.Select(x => new OrderViewModel
			{
				Id = x.Id,
				Customer = new CustomerViewModel
				{
					Id = x.Customer.Id,
					Name = x.Customer.Name,
					Manager = x.Customer.Manager,
					PhoneNumber = x.Customer.PhoneNumber,
					VatNumber = x.Customer.VatNumber,
					Address = x.Customer.Address,
					City = x.Customer.City

				},
				Products = x.Products.Select(p => new ProductViewModel
				{
					Id = p.Id,
					Name = p.Name,
					Price = p.Price,
					Quantity = p.Quantity,
					Image = p.Image,
					Description = p.Description,
					IsNew = p.IsNew
				}).ToList(),
			}).ToList();
			return orderViewModels;
		}

		public Task<OrderViewModel> GetOrder(int id)
		{
			throw new NotImplementedException();
		}

		public Task<bool> IsOrderExist(int id)
		{
			throw new NotImplementedException();
		}
	}
}
