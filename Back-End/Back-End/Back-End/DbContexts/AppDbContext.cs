using Back_End.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Back_End.DbContexts
{
    public class AppDbContext : IdentityDbContext<Utilisateur>
    {
        public AppDbContext(DbContextOptions<AppDbContext> option) : base(option)
        {            
        }

        public DbSet<Dose> Doses { get; set; }
        public DbSet<Utilisateur> Utilisateurs { get; set; }

    }
}
