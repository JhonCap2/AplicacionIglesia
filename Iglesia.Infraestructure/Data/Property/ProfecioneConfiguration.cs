using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iglesia.Infraestructure.Data.Property
{
    public class ProfecioneConfiguration : IEntityTypeConfiguration<Profecione>
    {
        public void Configure(EntityTypeBuilder<Profecione> builder)
        {
            builder.HasKey(e => e.IdProfecion1).HasName("PK__Profecio__94238CF82F8A1674");

            builder.Property(e => e.IdProfecion1)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("Id_Profecion");
            builder.Property(e => e.IdProfecion).ValueGeneratedOnAdd();
            builder.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false);
        }
    }
}
