using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TironeacSofia_lab8.Models;

namespace TironeacSofia_lab8.Data
{
    public class TironeacSofia_lab8Context : DbContext
    {
        public TironeacSofia_lab8Context (DbContextOptions<TironeacSofia_lab8Context> options)
            : base(options)
        {
        }

        public DbSet<TironeacSofia_lab8.Models.Book> Book { get; set; }

        public DbSet<TironeacSofia_lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<TironeacSofia_lab8.Models.Category> Category { get; set; }
    }
}
