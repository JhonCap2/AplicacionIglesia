using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iglesia.Infraestructure.Data.Property
{
    public class ConciliosConfiguration : IEntityTypeConfiguration<Concilio>
    {

        public void Configure(EntityTypeBuilder<Concilio> builder)
        {
            builder.HasKey(e => e.IdConcilio).HasName("PK__Concilio__70B1E5D927CB7AB4");

            builder.Property(e => e.IdConcilio)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("Id_Concilio");
            builder.Property(e => e.Correo)
                .HasMaxLength(50)
                .IsUnicode(false);
            builder.Property(e => e.IdRedSocial)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("Id_Red_Social");
            builder.Property(e => e.Rnc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RNC");
            builder.Property(e => e.Web)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.HasOne(d => d.IdRedSocialNavigation).WithMany(p => p.Concilios)
                .HasForeignKey(d => d.IdRedSocial)
                .HasConstraintName("FK_Redes_Sociales_Concilios");
        }
    }
}
