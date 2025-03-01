using AutoMapper;
using AutoMapper.QueryableExtensions;
using Echo_Merch.Data;
using Echo_Merch.Models;
using Microsoft.AspNetCore.Mvc;

namespace Echo_Merch.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ContactsController : ControllerBase
{
    private readonly ContextMerch _context;
    private readonly IMapper _mapper;

    public ContactsController(ContextMerch context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var l = _context.Users.ProjectTo<UserDTO>(_mapper.ConfigurationProvider).ToList();
        return Ok(l);
    }

    // GET api/<ContactsController>/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return "value";
    }

    // POST api/<ContactsController>
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/<ContactsController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/<ContactsController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}
