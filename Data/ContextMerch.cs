using Echo_Merch.Models;
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

    public DbSet<Echo_Merch.Models.Table1> Table1 { get; set; } = default!;

    public DbSet<Echo_Merch.Models.Table2> Table2 { get; set; } = default!;
}
