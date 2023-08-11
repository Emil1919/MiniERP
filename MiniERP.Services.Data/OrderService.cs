using Microsoft.EntityFrameworkCore;
using Mini_ERP.Data;
using MiniERP.Data.Models;
using MiniERP.Services.Data.Interfaces;
using MiniERP.Web.ViewModels;


namespace MiniERP.Services.Data
{
	
	// Comment( This class )
	/// <summary>
	/// This class is used for OrderService
	/// </summary>
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
		public Task<OrderFormViewModel> GetOrderForm()
		{
			OrderFormViewModel newOrderForm = new OrderFormViewModel();
			
			newOrderForm.Customers = dbContext.Customers.Select(x => new CustomerViewModel
			{
				Id = x.Id,
				Name = x.Name,
				Manager = x.Manager,
				PhoneNumber = x.PhoneNumber,
				VatNumber = x.VatNumber,
				Address = x.Address,
				City = x.City

			}).ToHashSet();
			newOrderForm.Products = dbContext.Products.Select(p => new ProductViewModel
			{
				Id = p.Id,
				Name = p.Name,
				Price = p.Price,
				Quantity = p.Quantity,
				Image = p.Image,
				Description = p.Description,
				IsNew = p.IsNew
			}).ToList();
			newOrderForm.SelectedProducts = dbContext.Products.Select(p => new ProductViewModel
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price,
                Quantity = 0,
                Image = p.Image,
                Description = p.Description,
                IsNew = p.IsNew
            }).ToList();

            return Task.FromResult(newOrderForm);
		}
		
	}
}
