using Echo_Merch.Models;
using Echo_Merch.Models.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Echo_Merch.Controllers
{
    public class UsersController : Controller
    {
        private readonly ContextMerch _context;

        public UsersController(ContextMerch context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            int[] x = { 2, 4 };
            int[] x2 = [2, 4];
            int[] x3 = { 2, 4 };
            int[] x4;
            List<int> y = new List<int> { 1, 2, 3, 4, 5 };

            Console.WriteLine(x);
            return Ok("");
        }

        // GET: Users
        //public async Task<IActionResult> Index()
        //{

        //    //string query = @"SELECT * FROM Users u
        //    //right  JOIN Contacts c ON u.Id = c.UserId";

        //    //var conn = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=test;Trusted_Connection=True;TrustServerCertificate=True;");
        //    //conn.Open();
        //    //SqlCommand command = new SqlCommand(query, conn);
        //    //SqlDataReader reader = command.ExecuteReader();
        //    //while (reader.Read())
        //    //{
        //    //    Console.WriteLine($"{reader["name"]} | {reader["Email"]}");
        //    //}
        //    //return Ok(reader);


        //    //return Ok("");

        //    var l = _context.Users.Where(r => r.Username == "username1");
        //    Console.WriteLine(_context.Users.Where(r => r.Username == "username1").Count());
        //    return View(_context.Users.Where(r => r.Username == "username1"));


        //    return View(await _context.Users.Include(u => u.Contact).ToListAsync());
        //    return View(await _context.Users.Select(u => new UserDTO { Username = u.Username, Name = u.Name }).Include(u => u.Contact).ToListAsync());
        //    return View(await (from u in _context.Users select new UserDTO { Username = u.Username, Name = u.Name }).ToListAsync());
        //}

        // GET: Users/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users
                .FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // GET: Users/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Users/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Username,Password,Email,Phone,City,Country")] User user)
        {
            if (ModelState.IsValid)
            {
                _context.Add(user);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        // GET: Users/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Username,Password,Email,Phone,City,Country")] User user)
        {
            if (id != user.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(user);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(user.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        // GET: Users/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users
                .FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user != null)
            {
                _context.Users.Remove(user);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserExists(int id)
        {
            return _context.Users.Any(e => e.Id == id);
        }
    }
}
