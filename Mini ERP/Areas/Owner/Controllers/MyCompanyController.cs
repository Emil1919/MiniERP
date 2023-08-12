using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Mini_ERP.Controllers;

namespace Mini_ERP.Areas.Owner.Controllers
{
    public class MyCompanyController : BaseController
    {
        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
