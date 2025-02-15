using Echo_Merch.Models;
using Echo_Merch.Models.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class ContextMerch : DbContext
{
    public ContextMerch(DbContextOptions<ContextMerch> options)
        : base(options)
    {
    }

    public DbSet<Echo_Merch.Models.User> Users { get; set; } = default!;
    public DbSet<Echo_Merch.Models.Contact> Contacts { get; set; } = default!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Contact>()
            .HasOne(o => o.User)
            .WithMany(c => c.Contact)
            .OnDelete(DeleteBehavior.Cascade); // Automatically delete orders when a customer is deleted
    }
}
