using MiniERP.Web.ViewModels;

namespace MiniERP.Services.Data.Interfaces
{
	public interface IOwnerService
	{
		Task<OwnerViewModel> GetInfo();
	}
}