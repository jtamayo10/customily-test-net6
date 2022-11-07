using CustomilyNETTest.Models;
using Microsoft.EntityFrameworkCore;

namespace customily_test_net6.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Item> Items { get; set; }
        public DbSet<Images> Images { get; set; }
        public DbSet<Texts> Texts { get; set; }

    }
}
