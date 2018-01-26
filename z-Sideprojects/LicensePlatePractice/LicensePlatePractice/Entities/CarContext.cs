using LicensePlatePractice.Models;
using Microsoft.EntityFrameworkCore;

namespace LicensePlatePractice.Entities
{
    public class CarContext : DbContext

    {
        public CarContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }
    }
}