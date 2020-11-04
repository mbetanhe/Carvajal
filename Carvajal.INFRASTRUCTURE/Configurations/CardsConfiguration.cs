using Carvajal.CORE.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Carvajal.INFRASTRUCTURE.Configurations
{
    public class CardsConfiguration : IEntityTypeConfiguration<Cards>
    {
        public void Configure(EntityTypeBuilder<Cards> entity)
        {
            entity.HasKey(e => e.primary);

            entity.ToTable("CARDS");

            entity.Property(e => e.primary).HasColumnName("CARDID");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(10)
                .IsFixedLength();
        }
    }
}
