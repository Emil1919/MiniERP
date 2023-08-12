using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Mini_ERP.Controllers;
using MiniERP.Services.Data.Interfaces;
using MiniERP.Web.ViewModels;

namespace Mini_ERP.Areas.Owner.Controllers
{
    public class MyCompanyController : BaseController
    {
        private readonly IOwnerService ownerService;
        public MyCompanyController(IOwnerService ownerService)
        {
            this.ownerService = ownerService;
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            OwnerViewModel owner = ownerService.GetInfo().Result;
            return View(owner);
        }
    }
}
