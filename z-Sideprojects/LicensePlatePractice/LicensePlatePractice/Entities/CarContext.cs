using LicensePlacePractice.Models;
using Microsoft.EntityFrameworkCore;

namespace LicensePlacePractice.Entities
{
    public class CarContext : DbContext

    {
        public CarContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }
    }
}
