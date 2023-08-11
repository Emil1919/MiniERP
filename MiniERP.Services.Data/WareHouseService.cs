using Microsoft.EntityFrameworkCore;
using Mini_ERP.Data;
using MiniERP.Services.Data.Interfaces;
using MiniERP.Web.ViewModels;

namespace MiniERP.Services.Data
{
    public class WareHouseService : IWareHouseService
    {
        MiniERP_DbContext dbContext;
        public WareHouseService(MiniERP_DbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<WareHouseViewModel> GetWareHouseInfo()
        {
          WareHouseViewModel wareHouse= new  WareHouseViewModel()
          {
              Address = dbContext.WareHouses.FirstOrDefault().Address,
              Name = dbContext.WareHouses.FirstOrDefault().Name,
              WareHouseManager =  dbContext.WareHouses.FirstOrDefault().WareHouseManager,
              Products = await dbContext.Products.Select(x => new ProductViewModel
              {
                  Id = x.Id,
                  Name = x.Name,
                  Price = x.Price,
                  Quantity = x.Quantity,
                  Description = x.Description,
                  IsDeleted = x.IsDeleted,
                  IsNew = x.IsNew,
                  
              }).ToListAsync()
          };
            return wareHouse;
           
            
        }
    }
}
