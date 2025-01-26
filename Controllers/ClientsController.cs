using Echo_Merch.Data;
using Echo_Merch.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Echo_Merch.Controllers;

//[ApiController]
[Route("[controller]")]
public class ClientsController() : Controller
{
	//public IActionResult asd([FromQuery] int q, [FromRoute] int r, [FromForm] string name, [FromBody] Client client) ////[ValidateAntiForgeryToken]
	//{
	//    Console.WriteLine(new { action = "asd", r, name, client, q });
	//    return Json(new { action = "asd", r, name, client, q });
	//}

	//public IActionResult create()
	//{ return View(); }

	[HttpPost]
	[Route("post/{r?}")]
	public IActionResult post(int? Q, string? R, int? number, int? age, Client client, string? text, string? title)
	{
		if (!ModelState.IsValid)
		{
			var errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage);
			return Ok(new { Q, R, number, age, text, title, client, errors });
		}

		return Json(new { Q, R, number, age, text, title, client });
	}

	//public IActionResult Edit(int q, int r, int number, string text, Client client)
	//{
	//    Console.WriteLine(new { action = "Edit", q, r, number, text, client });
	//    return Json(new { q, r, number, text, client });
	//}
}
