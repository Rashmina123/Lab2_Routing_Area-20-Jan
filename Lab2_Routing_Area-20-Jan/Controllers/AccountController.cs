using Lab2_Routing_Area_20_Jan.Models;
using Microsoft.AspNetCore.Mvc;

using System.Text.Json;

namespace Lab2_Routing_Area_20_Jan.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignUp(SignUpModel model)
        {
            if (ModelState.IsValid)
            {
               
                return RedirectToAction("LogIn");
            }
                

            return View();
        }
        [HttpGet]
        public IActionResult LogIn()
        {

            return View();
        }
        [HttpPost]  
        public IActionResult LogIn(LoginViewModel model)
        {
          //  string strUser = JsonSerializer.Serialize(model);
           
            ViewBag.Msg = "Welcome";
            TempData["User"] = model.UserName;
            if (model.UserName == "admin@gmail.com" &&  model.Password == "12345678")
            {

                string strUser = JsonSerializer.Serialize(model);

                HttpContext.Session.SetString("User", strUser);
                return RedirectToAction("Index", "Home", new {area="Admin"});
                
            }
            else if (model.UserName == "user@gmail.com" && model.Password == "12345678")
            {
                string strUser = JsonSerializer.Serialize(model);

                HttpContext.Session.SetString("User", strUser);
                return RedirectToAction("Index", "Home", new { area = "User" });
            }
            ViewBag.ErrorMsg = "UserName or Password should not Correct!";
            return View();  
        }

        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();
            return View();
        } 
    }
}
