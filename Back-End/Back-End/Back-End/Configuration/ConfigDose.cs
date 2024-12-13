using Back_End.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Back_End.Configuration
{
    public class ConfigDose : IEntityTypeConfiguration<Utilisateur>
    {
        public void Configure(EntityTypeBuilder<Utilisateur> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasMany(d => d.Doses)
                .WithOne(u => u.Utilisateur)
                .HasForeignKey(u =>u.IdUtilisateur)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
