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
public class ClientsController() : Controller
{
    //public IActionResult asd([FromQuery] int q, [FromRoute] int id, [FromForm] string name, [FromBody] Client client) ////[ValidateAntiForgeryToken]
    //{
    //    Console.WriteLine(new { action = "asd", id, name, client, q });
    //    return Json(new { action = "asd", id, name, client, q });
    //}

    //public IActionResult create()
    //{ return View(); }

    [HttpPost]
    [Route("/clients/{r?}")]
    public IActionResult post(int q, int r, int number, string? text, [FromBody] Client client)
    {
        if (!ModelState.IsValid)
        {
            var errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage);
            return BadRequest(errors);
        }

        Console.WriteLine(new { q, r, number, text, client });
        return Json(new { q, r, number = Request.Form["number"], text = Request.Form["text"], client = Request.Form["client"] });
    }

    //public IActionResult Edit(int q, int r, int number, string text, Client client)
    //{
    //    Console.WriteLine(new { action = "Edit", q, r, number, text, client });
    //    return Json(new { q, r, number, text, client });
    //}
}
