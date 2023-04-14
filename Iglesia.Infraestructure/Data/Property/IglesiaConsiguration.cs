using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iglesia.Infraestructure.Data.Property
{
    public class IglesiaConsiguration : IEntityTypeConfiguration<Iglesia>
    {
        public void Configure(EntityTypeBuilder<Iglesia> builder)
        {
            builder.HasKey(e => e.IdIglesia).HasName("PK__Iglesias__1DC6931A1F834C89");

            builder.Property(e => e.IdIglesia)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("Id_Iglesia");
            builder.Property(e => e.IdConcilios)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("Id_Concilios");
            builder.Property(e => e.IdDireccion)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("Id_Direccion");
            builder.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            builder.Property(e => e.Web)
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.HasOne(d => d.IdConciliosNavigation).WithMany(p => p.Iglesia)
                .HasForeignKey(d => d.IdConcilios)
                .HasConstraintName("FK_Concilios_Iglesias");

            builder.HasOne(d => d.IdDireccionNavigation).WithMany(p => p.Iglesia)
                .HasForeignKey(d => d.IdDireccion)
                .HasConstraintName("FK_Direcciones_Iglesias");
        }
    }
}
