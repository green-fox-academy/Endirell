using Microsoft.EntityFrameworkCore;
using WebStore.Models;

namespace WebStore.Entities
{
    public class WebStoreContext : DbContext
    {
        public WebStoreContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Dress> Dresses { get; set; }
    }
}
