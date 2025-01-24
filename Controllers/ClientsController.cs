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
//[Route("clients/{r?}")]
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
    public IActionResult post(string Q, int R, string text, string title, Client client, int number)
    {
        if (!ModelState.IsValid)
        {
            var errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage);
            return Json(errors);
        }

        Console.WriteLine(text + number + title);
        return Json(new { Q, R, number, text, title, client });
    }

    //public IActionResult Edit(int q, int r, int number, string text, Client client)
    //{
    //    Console.WriteLine(new { action = "Edit", q, r, number, text, client });
    //    return Json(new { q, r, number, text, client });
    //}
}
