using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SecuredHub.Models;
using SecuredHub.Business.AuthService.Interface;

namespace SecuredHub.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAuthService _authService;

        public HomeController(IAuthService authService)
        {
            _authService = authService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View("~/Views/Home/Login.cshtml");
        }

        public IActionResult Register()
        {
            return View("~/Views/Home/Register.cshtml");
        }


        public IActionResult Dashboard()
        {
            return View("~/Views/Home/MainPage.cshtml");
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}