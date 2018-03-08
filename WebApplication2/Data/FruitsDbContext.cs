using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Data
{
    public class FruitDbContext : DbContext
    {


        public FruitDbContext(DbContextOptions<FruitDbContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplication2.Models.Fruit> Fruit { get; set; }

    }
}
