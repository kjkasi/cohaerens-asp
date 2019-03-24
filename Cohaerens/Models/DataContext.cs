using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Cohaerens.Models
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options) { }

        public DbSet<SysCom> SysComs { get; set; }

        public DbSet<Place> Places { get; set; }
    }
}
