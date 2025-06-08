using APPDEV_WebApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace APPDEV_WebApplication.Models
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(LoginModel model)
        {
            // Dummy hardcoded login
            if (model.Username == "admin" && model.Password == "password")
            {
                ViewBag.Message = "Login successful!";
                return View("Success");
            }

            ViewBag.Message = "Invalid username or password.";
            return View();
        }

        public IActionResult Success()
        {
            return View();
        }
    }
}
