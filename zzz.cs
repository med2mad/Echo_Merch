using Microsoft.Data.SqlClient;
using System;
using System.Data;
using Microsoft.AspNetCore.Mvc;
using System.Configuration;
using Echo_Merch.Data;
using Echo_Merch.Models;

namespace Echo_Merch
{
	public class Zzz(IConfiguration configuration) : Controller
	{
		private readonly string? _connectionString = configuration.GetConnectionString("DefaultConnection");

		public string index()
		{
			return "View()";
		}
		public IActionResult index1()
		{
			return View();
		}

		public string zzzz(){

			var context = new ModelContextTest();

			context.Database.EnsureDeleted();
			context.Database.EnsureCreated();


			return $"";
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
