using Echo_Merch.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Echo_Merch.Controllers
{
    public class home : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("/rrr")]
        public string Privacy()
        {
            return "rrr";
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
