using Echo_Merch.Models;
using Microsoft.EntityFrameworkCore;

namespace Echo_Merch.Data
{
	public class ApplicationDbContext : DbContext
	{
		public DbSet<Client> czzz { get; set; }
		public DbSet<Product> pzzz { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=test;Trusted_Connection=True;TrustServerCertificate=True;");
		}
	}
}
