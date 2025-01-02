using Microsoft.AspNetCore.Mvc;

namespace Echo_Merch
{
	public class zzz : Controller
	{
		public string index()
		{
			return "View()";
		}
		public IActionResult index1()
		{
			return View();
		}

		public IActionResult zzzz(){
			
			return View();
		}
		[HttpPost]
		public IActionResult zzzz(typeName model)
		{
			if (ModelState.IsValid)
			{
                return Content("Well done !");
            }
			return NotFound();
		}
		[HttpPost]
		public string rrr(string a, string b)
		{
			string x = "zzz";
			return Request.Form["a"] + Request.Form["b"];

		}
	}
}
