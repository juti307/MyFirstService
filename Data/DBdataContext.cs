using Microsoft.EntityFrameworkCore;
using MyFirstService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstService.Data
{
    public class DBdataContext : DbContext
    {
        public DBdataContext(DbContextOptions options) : base(options) { }

        public DbSet<Product> Product { get; set; }

    }
}
