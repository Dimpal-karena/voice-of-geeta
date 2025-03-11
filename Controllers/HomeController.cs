using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using The_voice_of_geeta.Models;

namespace The_voice_of_geeta.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult Shloka()
        {
            return View();
        }
    }
}
