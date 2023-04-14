using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iglesia.Infraestructure.Data.Property
{
    public class EstadosCivileConfiguration : IEntityTypeConfiguration<EstadosCivile>
    {
        public void Configure(EntityTypeBuilder<EstadosCivile> builder)
        {
            builder.HasKey(e => e.IdEstadoCivil).HasName("PK__Estados___CAE6659AFE723986");

            builder.ToTable("Estados_Civiles");

            builder.Property(e => e.IdEstadoCivil)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("Id_Estado_Civil");
            builder.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false);
        }
    }
}
