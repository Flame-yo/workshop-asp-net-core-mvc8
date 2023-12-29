using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc8.Models;

namespace SalesWebMvc8.Data
{
    public class SalesWebMvc8Context : DbContext
    {
        public SalesWebMvc8Context (DbContextOptions<SalesWebMvc8Context> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
