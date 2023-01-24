using Microsoft.AspNetCore.Mvc;

namespace Lab2_Routing_Area_20_Jan.Areas.User.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
