using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iglesia.Infraestructure.Data.Property
{
    public class MiembroConfiguration : IEntityTypeConfiguration<Miembro>
    {
        public void Configure(EntityTypeBuilder<Miembro> builder)
        {

            builder.HasKey(e => e.IdMiembro).HasName("PK__Miembros__35CDB17438BF41C4");

            builder.Property(e => e.IdMiembro)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("Id_Miembro");
            builder.Property(e => e.Apodo)
                .HasMaxLength(50)
                .IsUnicode(false);
            builder.Property(e => e.FechaDeNacimiento)
                .HasColumnType("date")
                .HasColumnName("Fecha_De_Nacimiento");
            builder.Property(e => e.IdDireccion)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("Id_Direccion");
            builder.Property(e => e.IdEstadoCivil)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("Id_Estado_Civil");
            builder.Property(e => e.IdIglesia)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("Id_Iglesia");
            builder.Property(e => e.IdProfecion)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("Id_Profecion");
            builder.Property(e => e.PrimerApellido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Primer_Apellido");
            builder.Property(e => e.PrimerNombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Primer_Nombre");
            builder.Property(e => e.SegundoApellido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Segundo_Apellido");
            builder.Property(e => e.SegundoNombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Segundo_Nombre");

            builder.HasOne(d => d.IdDireccionNavigation).WithMany(p => p.Miembros)
                .HasForeignKey(d => d.IdDireccion)
                .HasConstraintName("FK_Direcciones_Miembros");

            builder.HasOne(d => d.IdEstadoCivilNavigation).WithMany(p => p.Miembros)
                .HasForeignKey(d => d.IdEstadoCivil)
                .HasConstraintName("FK_Estado_Civiles_Miembros");

            builder.HasOne(d => d.IdIglesiaNavigation).WithMany(p => p.Miembros)
                .HasForeignKey(d => d.IdIglesia)
                .HasConstraintName("FK_Iglesias_Miembros");

            builder.HasOne(d => d.IdProfecionNavigation).WithMany(p => p.Miembros)
                .HasForeignKey(d => d.IdProfecion)
                .HasConstraintName("FK_Profeciones_Miembros");
        }
    }
}
