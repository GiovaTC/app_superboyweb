using app_superboyweb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace app_superboyweb.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

    }
}
