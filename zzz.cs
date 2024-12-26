using Microsoft.AspNetCore.Mvc;

namespace Echo_Merch
{
    public class zzz:Controller
    {
        public IActionResult index()
        {
            return View();
        }
        public IActionResult index1()
        {
            return View();
        }
		[Route("/")]
		public IActionResult zzzz()
		{
            
            return View();
		}
		public IActionResult rrr()
		{
			return View();
		}
	}
}
