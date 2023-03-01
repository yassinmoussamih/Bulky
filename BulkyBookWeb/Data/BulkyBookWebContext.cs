using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BulkyBookWeb.Models;

namespace BulkyBookWeb.Data
{
    public class BulkyBookWebContext : DbContext
    {
        public BulkyBookWebContext (DbContextOptions<BulkyBookWebContext> options)
            : base(options)
        {
        }

        public DbSet<BulkyBookWeb.Models.Category> Category { get; set; } = default!;
    }
}
