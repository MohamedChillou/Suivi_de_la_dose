using Back_End.Data;
using Microsoft.EntityFrameworkCore;

namespace Back_End.DbContexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> option) : base(option)
        {            
        }

        public DbSet<Dose> Doses { get; set; }

    }
}
