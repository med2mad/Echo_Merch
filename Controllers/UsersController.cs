using AutoMapper;
using AutoMapper.QueryableExtensions;
using Echo_Merch.Data;
using Echo_Merch.Models;
using Microsoft.AspNetCore.Mvc;

namespace Echo_Merch.Controllers;

[Route("[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly ContextMerch _context;
    private readonly IMapper _mapper;

    public UsersController(ContextMerch context, IMapper mapper)
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


    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        var u = _context.Users.Find(id);
        if (u is null)
        {
            return NotFound();
        }

        return Ok(u);
    }

    [HttpPost]
    public IActionResult Post([FromBody] AddUserDTO u)
    {
        User newUser = AddUserDTO.Mapping(u);

        _context.Users.Add(newUser);
        _context.SaveChanges();

        return Ok(newUser);
    }

    [HttpPut("{id}")]
    public IActionResult Put(int id, [FromBody] AddUserDTO argU)
    {
        var u = _context.Users.Find(id);
        if (u is null)
        {
            return NotFound();
        }

        u.Name = argU.Name;
        u.Username = argU.Username;
        u.Password = argU.Password;
        u.City = argU.City;
        u.Country = argU.Country;

        _context.SaveChanges();

        return Ok(u);
    }

    // DELETE api/<UsersController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}
