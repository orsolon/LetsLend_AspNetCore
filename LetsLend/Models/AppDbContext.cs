using Microsoft.EntityFrameworkCore;

namespace LetsLend.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }
        public DbSet<Borrower> Users { get; set; }
        public DbSet<Item> Items { get; set; }
    }
}
