using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iglesia.Infraestructure.Data.Property
{
    public class DireccioneConfiguration : IEntityTypeConfiguration<Direccione>
    {
        public void Configure(EntityTypeBuilder<Direccione> builder)
        {
            builder.HasKey(e => e.IdDireccion).HasName("PK__Direccio__535FD6115D4E7E90");

            builder.Property(e => e.IdDireccion)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("Id_Direccion");
            builder.Property(e => e.DireccionIglesia)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Direccion_Iglesia");
        }
    }
}
