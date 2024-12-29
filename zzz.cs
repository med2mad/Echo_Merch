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
			typeName model = new typeName();
			return View(model);
		}
		[HttpPost]
		public IActionResult zzzz(typeName model)
		{
			Console.WriteLine(ModelState);
			// Model binding populates 'model' from the form submission
			return View(model);
		}
		[HttpPost]
		public string rrr(string a, string b)
		{
			string x = "zzz";
			return Request.Form["a"] + Request.Form["b"];

		}
	}
}
