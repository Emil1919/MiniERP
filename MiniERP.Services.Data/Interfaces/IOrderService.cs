using MiniERP.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP.Services.Data.Interfaces
{
	/// <summary>
	/// This interface is used for OrderService
	/// </summary>
	public interface IOrderService
	{
		public Task<bool> IsOrderExist(int id);
		public Task<IEnumerable<OrderViewModel>> GetAllOrders();
		public Task<bool> AddOrder(OrderViewModel order);
		public Task<OrderViewModel> GetOrder(int id);
		public Task EditOrder(OrderViewModel order);
		public Task DeleteOrder(OrderViewModel order);
		public Task<OrderFormViewModel> GetOrderForm();
	}
}
