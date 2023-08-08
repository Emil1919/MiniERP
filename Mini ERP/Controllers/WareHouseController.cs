using Microsoft.AspNetCore.Mvc;
using MiniERP.Services.Data.Interfaces;
using MiniERP.Web.ViewModels;

namespace Mini_ERP.Controllers
{
    public class WareHouseController : BaseController
    {
        private readonly IWareHouseService wareHouseService;
        public WareHouseController(IWareHouseService wareHouseService)
        {
            this.wareHouseService = wareHouseService;
        }
        public IActionResult Index()
        {
              WareHouseViewModel wareHouseViewModel = wareHouseService.GetWareHouseInfo().Result;
            return View(wareHouseViewModel);
           
        }

       
    }
}
