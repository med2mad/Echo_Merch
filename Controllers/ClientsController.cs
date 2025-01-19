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


[Route("/clients")]

public class ClientsController() : Controller
{

    public string Index()
    {
        return "index";
    }

    [HttpGet("/{x}")]
    public string Details(string x)
    {
        return $"Details {x}";
    }

    [HttpPost]
    //[ValidateAntiForgeryToken]
    public string Create([FromBody] Client client)
    {
        Console.WriteLine($"clientid {client.clientid}, Name {client.Name}, Description {client.Description}");
        return System.Text.Json.JsonSerializer.Serialize(client);
    }

    [HttpPost("2")]
    [ValidateAntiForgeryToken]
    public string Edit(int id, Client client)
    {
        Console.WriteLine($"clientid {client.clientid}, Name {client.Name}, Description {client.Description}");
        return $"clientid {client.clientid}, Name {client.Name}, Description {client.Description}";
    }
}
