namespace MiniERP.Services.Data.Interfaces
{
	public interface IOwnerService
	{
		Task<OwnerViewModel> GetInfo();
	}
}