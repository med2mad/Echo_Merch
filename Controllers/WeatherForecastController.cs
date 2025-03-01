using AutoMapper;
using AutoMapper.QueryableExtensions;
using Echo_Merch.Data;
using Echo_Merch.Models;
using Echo_Merch.Models.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Echo_Merch.Controllers;
[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly ContextMerch _context;
    private readonly IMapper _mapper;

    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger, ContextMerch context, IMapper mapper)
    {
        _logger = logger;
        _context = context;
        _mapper = mapper;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IActionResult Get()
    {
        var l = _context.Users.ProjectTo<User>(_mapper.ConfigurationProvider).ToList();

        //var l = _context.Users.Select(u => new User { Name = u.Name, Username = u.Username }).ToList();
        return Ok(l);
    }
}
