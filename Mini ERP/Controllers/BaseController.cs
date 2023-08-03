using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Mini_ERP.Controllers
{
	[Authorize]
	public class BaseController : Controller
	{
		
	}
}
