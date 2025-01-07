using Echo_Merch.Models;
using Microsoft.EntityFrameworkCore;

namespace Echo_Merch.Data
{
	public class Table2 : DbContext
	{
		public DbSet<Client> Clients { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=test;Trusted_Connection=True;TrustServerCertificate=True;");
		}
	}
}
