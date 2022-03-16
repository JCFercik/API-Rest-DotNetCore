using FilmesApi.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmesApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base (opt)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Endereco>() // Define a entidade
                .HasOne(endereco => endereco.Cinema) // endereço tem um cinema
                .WithOne(Cinema => Cinema.Endereco) // cinema possui um endereço
                .HasForeignKey<Cinema>(cinema => cinema.EnderecoId); // A FK esta em Cinema e é EnderecoId
        }

        public DbSet<Filmes> Filmes { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
    }
}
