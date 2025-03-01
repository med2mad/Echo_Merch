using Echo_Merch.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Echo_Merch.Data
{
    public class ContextMerch : DbContext
    {
        public ContextMerch(DbContextOptions<ContextMerch> options)
            : base(options)
        {
        }

        public DbSet<Echo_Merch.Models.User> Users { get; set; } = default!;
        public DbSet<Echo_Merch.Models.Contact> Contacts { get; set; } = default!;
    }
}
