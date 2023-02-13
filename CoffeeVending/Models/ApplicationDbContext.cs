using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace CoffeeVending.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options)
          : base(options)
        { }
        public DbSet<Coffee> Coffees { get; set; }
    }
}

