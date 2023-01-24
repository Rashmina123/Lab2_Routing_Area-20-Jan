using Microsoft.AspNetCore.Mvc;

namespace Lab2_Routing_Area_20_Jan.Areas.Admin.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
