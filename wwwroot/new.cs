using Microsoft.AspNetCore.Mvc;

namespace Echo_Merch
{
    public class New:Controller
    {
        [Route("/cool")]
        public IActionResult Index()
        {
            return "cool";
        }
    }
}