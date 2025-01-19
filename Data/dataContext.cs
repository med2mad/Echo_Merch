using Echo_Merch.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Echo_Merch.Data
{
    public class dataContext : DbContext
    {
        public dataContext(DbContextOptions<dataContext> options)
            : base(options)
        {
        }

        public DbSet<Echo_Merch.Models.Client> Clients { get; set; } = default!;
        public DbSet<Echo_Merch.Models.Product> Product { get; set; } = default!;
    }
}
