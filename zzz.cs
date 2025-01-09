using Microsoft.Data.SqlClient;
using System;
using System.Data;
using Microsoft.AspNetCore.Mvc;
using System.Configuration;
using Echo_Merch.Data;
using Echo_Merch.Models;
using Microsoft.EntityFrameworkCore;

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

		public string zzzz(){
			var context = new ApplicationDbContext();

			//var client = new Client { Name = "11", Description = "111" };
			var client = context.Clients.Find(3);
			//context.Clients.Attach(client);
			//context.Entry(client).State = EntityState.Modified;
			client.Name = "adasd";
			//context.Clients.Add(client);
			context.Clients.Update(client);
			//context.Clients.Remove(client);

			context.SaveChanges();

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
