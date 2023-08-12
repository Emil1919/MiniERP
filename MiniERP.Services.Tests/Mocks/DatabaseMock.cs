

using Microsoft.EntityFrameworkCore;
using Mini_ERP.Data;

namespace MiniERP.Services.Tests.Mocks
{
	public static class DatabaseMock
	{
		public static MiniERP_DbContext Instance
		{
			get
			{
				var dbContextOptions = new DbContextOptionsBuilder<MiniERP_DbContext>()
					.UseInMemoryDatabase(databaseName: "MiniERP_InMemoryDb" + DateTime.Now.Ticks.ToString())
					.Options;

				return new MiniERP_DbContext(dbContextOptions);
			}
		}
	}
}
