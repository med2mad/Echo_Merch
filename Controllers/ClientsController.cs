using Echo_Merch.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Echo_Merch;

public class Clients(IConfiguration configuration) : Controller
{
	public IActionResult index()
	{
		return View();
	}

	public IActionResult zzzz()
	{
		return View();
	}

	[HttpPost]
	public IActionResult zzzz(int Q, int R, int number, string text, Client client)
	{
		ViewBag.Q = Q;
		ViewBag.R = R;
		ViewBag.number = number;
		ViewBag.text = text;
		if (!ModelState.IsValid)
		{
			ViewBag.errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage).ToList();
			return View(client);
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
