using Echo_Merch.Models;
using Microsoft.AspNetCore.Mvc;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Echo_Merch;

public class zzz(IConfiguration configuration) : Controller
{
	public IActionResult index1()
	{
		return View();
	}

	public IActionResult zzzz()
	{


		return View();
	}

	[HttpPost]
	public IActionResult zzzz(int? Q, string? R, string number, int age, string text, string name, Client client)
	{
		if (!ModelState.IsValid)
		{
			var errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage);
			return Ok(new { Q, R, number, age, text, name, client, errors });
		}
		return View(client);
	}
	[HttpPost]
	public string rrr(string a, string b)
	{
		string x = "zzz";
		return Request.Form["a"] + Request.Form["b"];

	}
}
