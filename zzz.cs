using Microsoft.AspNetCore.Mvc;

namespace Echo_Merch;

public class zzz(IConfiguration configuration) : Controller
{
	public IActionResult index()
	{
		return View();
	}

	public string zzzz()
	{


		return $"wwwwwwww";
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
