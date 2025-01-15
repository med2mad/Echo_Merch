using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Echo_Merch.Data;
using Echo_Merch.Models;

namespace Echo_Merch.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly Echo_Merch.Data.ApplicationDbContext _context;

        public IndexModel(Echo_Merch.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Product = await _context.Product.ToListAsync();
        }
    }
}
