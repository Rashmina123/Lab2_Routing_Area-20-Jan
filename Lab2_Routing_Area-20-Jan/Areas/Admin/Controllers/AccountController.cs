using Microsoft.AspNetCore.Mvc;

namespace Lab2_Routing_Area_20_Jan.Areas.Admin.Controllers
{
    public class AccountController : BaseController
    {
        public IActionResult Profile()
        {
            return View();
        }
    }
}
