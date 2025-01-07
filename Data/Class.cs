using Echo_Merch.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Echo_Merch.Data
{
	public class AppDbContext : DbContext { 

		public DbSet<Client> Clients { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=test;Trusted_Connection=True;TrustServerCertificate=True;");
		}
	}
}