using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Controllers
{
	[AllowAnonymous]

	public class MessageCategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}