using FilmesApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base (opt)
        {

        }

        public DbSet<Filmes> Filmes { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
    }
}
