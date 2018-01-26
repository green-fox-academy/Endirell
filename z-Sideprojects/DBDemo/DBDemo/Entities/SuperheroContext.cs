using DBDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace DBDemo.Entities
{
    public class SuperheroContext : DbContext
    {
        public SuperheroContext(DbContextOptions<SuperheroContext> options) : base(options)
        {
        }

        public DbSet<Superhero> Superheroes { get; set; }
    }
}
