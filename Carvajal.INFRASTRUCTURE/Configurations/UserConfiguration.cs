using Carvajal.CORE.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Carvajal.INFRASTRUCTURE.Configurations
{
    /// <summary>
    /// Se aplican las configuraciones para el mapeo de las entidades con la tabla de usuarios.
    /// </summary>
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> entity)
        {
            entity.HasKey(e => e.primary);

            entity.ToTable("USER");

            entity.Property(e => e.primary).HasColumnName("IDUSER");

            entity.Property(e => e.Cardid).HasColumnName("CARDID");

            entity.Property(e => e.Email)
                .IsRequired()
                .HasColumnName("EMAIL")
                .HasMaxLength(100);

            entity.Property(e => e.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasMaxLength(11);

            entity.Property(e => e.Lastname)
                .IsRequired()
                .HasColumnName("LASTNAME")
                .HasMaxLength(50);

            entity.Property(e => e.Name)
                .IsRequired()
                .HasColumnName("NAME")
                .HasMaxLength(50);

            entity.Property(e => e.Password)
                .IsRequired()
                .HasColumnName("PASSWORD")
                .HasMaxLength(16);
        }
    }
}
