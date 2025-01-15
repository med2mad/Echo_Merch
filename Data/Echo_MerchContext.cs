using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Echo_Merch.Models;

namespace Echo_Merch.Data
{
    public class Echo_MerchContext : DbContext
    {
        public Echo_MerchContext (DbContextOptions<Echo_MerchContext> options)
            : base(options)
        {
        }

        public DbSet<Echo_Merch.Models.Client> Client { get; set; } = default!;
    }
}
