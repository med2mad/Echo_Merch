using Echo_Merch.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Echo_Merch.Controllers
{
    public class Table1_Controller : Controller
    {
        private readonly ContextMerch _context;

        public Table1_Controller(ContextMerch context)
        {
            _context = context;
        }

        // GET: Table1_
        public async Task<IActionResult> Index()
        {
            return View(await _context.Table1_.Include(t => t.Table1).ToListAsync());
        }

        // GET: Table1_/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var table1_ = await _context.Table1_
                .FirstOrDefaultAsync(m => m.Id == id);
            if (table1_ == null)
            {
                return NotFound();
            }

            return View(table1_);
        }

        // GET: Table1_/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Table1_/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Value")] Table1_ table1_)
        {
            if (ModelState.IsValid)
            {
                _context.Add(table1_);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(table1_);
        }

        // GET: Table1_/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var table1_ = await _context.Table1_.FindAsync(id);
            if (table1_ == null)
            {
                return NotFound();
            }
            return View(table1_);
        }

        // POST: Table1_/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Value")] Table1_ table1_)
        {
            if (id != table1_.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(table1_);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Table1_Exists(table1_.Id))
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
            return View(table1_);
        }

        // GET: Table1_/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var table1_ = await _context.Table1_
                .FirstOrDefaultAsync(m => m.Id == id);
            if (table1_ == null)
            {
                return NotFound();
            }

            return View(table1_);
        }

        // POST: Table1_/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var table1_ = await _context.Table1_.FindAsync(id);
            if (table1_ != null)
            {
                _context.Table1_.Remove(table1_);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Table1_Exists(int id)
        {
            return _context.Table1_.Any(e => e.Id == id);
        }
    }
}
