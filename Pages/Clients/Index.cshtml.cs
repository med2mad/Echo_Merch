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
	public class IndexModel : PageModel
	{
		private readonly Echo_Merch.Data.Echo_MerchContext _context;

		public IndexModel(Echo_Merch.Data.Echo_MerchContext context)
		{
			_context = context;
		}

		public IList<Client> Client { get; set; } = default!;

		public async Task OnGetAsync()
		{
			Client = await _context.Client.ToListAsync();
		}
	}
}
