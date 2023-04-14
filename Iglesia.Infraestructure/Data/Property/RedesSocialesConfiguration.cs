using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iglesia.Infraestructure.Data.Property
{
    public class RedesSocialesConfiguration : IEntityTypeConfiguration<RedesSociale>
    {
        public void Configure(EntityTypeBuilder<RedesSociale> builder)
        {
            builder.HasKey(e => e.IdRedSocial).HasName("PK__Redes_So__67E3BBC9A4DB1B82");

            builder.ToTable("Redes_Sociales");

            builder.Property(e => e.IdRedSocial)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("Id_Red_Social");
            builder.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        }
    }
}
