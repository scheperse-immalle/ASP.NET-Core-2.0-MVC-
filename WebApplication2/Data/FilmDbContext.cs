using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Models
{
    public class FilmDbContext : DbContext
    {
        public FilmDbContext (DbContextOptions<FilmDbContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplication2.Models.Film> Film { get; set; }
    }
}
