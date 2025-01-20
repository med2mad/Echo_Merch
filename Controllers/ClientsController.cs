using Echo_Merch.Data;
using Echo_Merch.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Echo_Merch.Controllers;

[Route("clients")]
public class ClientsController() : Controller
{

    [HttpGet]
    public string Index()
    {
        return "indexsssss";
    }

    [HttpPost]
    //[ValidateAntiForgeryToken]
    public Client Create([FromBody] Client client)
    {
        Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(client));
        return client;
    }

    [HttpPost("edit/{id}")]
    //[ValidateAntiForgeryToken]
    public Client Edit([FromQuery] int q, [FromRoute] int id, [FromForm] Client client)
    {
        Console.WriteLine($"q {q}, id {id}, clientid {client.clientid}, Name {client.Name}, Description {client.Description}");
        return client;
    }
}