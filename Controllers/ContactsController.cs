using AutoMapper;
using AutoMapper.QueryableExtensions;
using Echo_Merch.Data;
using Echo_Merch.Models;
using Microsoft.AspNetCore.Mvc;

namespace Echo_Merch.Controllers;



public class ContactsController : ControllerBase
{
    private readonly ContextMerch _context;
    private readonly IMapper _mapper;

    public ContactsController(ContextMerch context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpGet("")]
    public IActionResult GetAll()
    {
        var l = _context.Contacts.ProjectTo<ContactDTO>(_mapper.ConfigurationProvider).ToList();
        return Ok(l);
    }

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        var c = _context.Contacts.Find(id);
        if (c is null)
        {
            return NotFound();
        }

        return Ok(c);
    }

    [HttpPost]
    public IActionResult Post([FromBody] Contact c)
    {
        _context.Contacts.Add(c);
        _context.SaveChanges();

        return Ok(c);
    }

    [HttpPut("{id}")]
    public IActionResult Put(int id, [FromBody] Contact argC)
    {
        Contact? c = _context.Contacts.Find(id);
        if (c is null)
        {
            return NotFound();
        }

        c.Phone = argC.Phone;
        c.Email = argC.Email;
        c.WhatsApp = argC.WhatsApp;
        c.address = argC.address;
        c.UserId = argC.UserId;
        _context.SaveChanges();

        return Ok(c);
    }

    // DELETE api/<ContactsController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}
