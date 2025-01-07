using Echo_Merch.Models;
using Microsoft.EntityFrameworkCore;

namespace Echo_Merch.Data
{
	public class ModelContextTest : DbContext
	{
		public DbSet<Modeltest> Modeltest { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			// Replace "YourConnectionStringHere" with your actual database connection string
			optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=test;Trusted_Connection=True;TrustServerCertificate=True;");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			// Specify table name explicitly if it doesn't match the class name
			modelBuilder.Entity<Modeltest>()
				.ToTable("Modeltest", "dbo") // Modeltest in dbo schema
				.HasKey(t => t.Id); // Specify primary key

			// Configure column mappings (optional if property names match column names)
			modelBuilder.Entity<Modeltest>()
				.Property(t => t.Column1)
				.HasMaxLength(50)
				.IsRequired(false); // Column1 is varchar(50), nullable by default

			modelBuilder.Entity<Modeltest>()
				.Property(t => t.Column2)
				.HasMaxLength(50)
				.IsRequired(false); // Column2 is varchar(50), nullable by default
		}


	}
}



