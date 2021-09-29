using Microsoft.EntityFrameworkCore;

namespace LetsLend.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }
        public DbSet<Borrower> Pessoas { get; set; }
        public DbSet<Item> Itens { get; set; }
    }
}
