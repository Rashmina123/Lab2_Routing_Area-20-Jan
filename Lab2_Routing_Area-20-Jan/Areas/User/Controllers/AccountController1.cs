using Microsoft.AspNetCore.Mvc;

namespace Lab2_Routing_Area_20_Jan.Areas.User.Controllers
{
    public class AccountController1 : BaseController
    {
        public IActionResult Profile()
        {
            return View();
        }
    }
}
