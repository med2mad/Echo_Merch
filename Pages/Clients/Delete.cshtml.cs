using Echo_Merch.Data;
using Echo_Merch.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Echo_Merch.Pages.Clients
{
	public class DeleteModel : PageModel
	{
		private readonly Echo_Merch.Data.Echo_MerchContext _context;

		public DeleteModel(Echo_Merch.Data.Echo_MerchContext context)
		{
			_context = context;
		}

		[BindProperty]
		public Client Client { get; set; } = default!;

		public async Task<IActionResult> OnGetAsync(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var client = await _context.Client.FirstOrDefaultAsync(m => m.clientid == id);

			if (client == null)
			{
				return NotFound();
			}
			else
			{
				Client = client;
			}
			return Page();
		}

		public async Task<IActionResult> OnPostAsync(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var client = await _context.Client.FindAsync(id);
			if (client != null)
			{
				Client = client;
				_context.Client.Remove(Client);
				await _context.SaveChangesAsync();
			}

			return RedirectToPage("./Index");
		}
	}
}
