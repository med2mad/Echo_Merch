using Echo_Merch.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Echo_Merch.Controllers;
[Route("api/[controller]")]
[ApiController]
public class clientsapi : ControllerBase
{
    // GET: api/<clientsapi>
    [HttpGet]
    public IEnumerable<string> Get()
    {
        return new string[] { "value1", "value2" };
    }

    // GET api/<clientsapi>/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return "value";
    }

    // POST api/<clientsapi>
    [HttpPost]
    public void Post([FromBody] Client value)
    {
        Console.WriteLine(value.age);
    }

    // PUT api/<clientsapi>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/<clientsapi>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}
