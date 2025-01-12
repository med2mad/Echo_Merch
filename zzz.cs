using Echo_Merch.Data;
using Microsoft.AspNetCore.Mvc;

namespace Echo_Merch
{
	public class Zzz(IConfiguration configuration) : Controller
	{
		public string index()
		{
			return "View()";
		}
		public IActionResult index1()
		{
			return View();
		}

		public string zzzz()
		{
			var context = new ApplicationDbContext();
			//var x = context.Clients.ToList();
			//var x = context.Clients.Where(r => true);
			int[] x = [3, 4, 5];
			var xx = from aa in x where true select aa * 10;


			foreach (var z in xx)
			{
				Console.WriteLine(z);
			}

			//context.Database.EnsureDeleted();
			//context.Database.EnsureCreated();


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
}
