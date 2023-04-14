using System;
using System.Collections.Generic;
using Iglesia.Infraestructure.Data.Property;
using Microsoft.EntityFrameworkCore;

namespace Iglesia.Infraestructure.Data;

public partial class DbIglesiaContext : DbContext
{
    public DbIglesiaContext()
    {
    }

    public DbIglesiaContext(DbContextOptions<DbIglesiaContext> options)
        : base(options)
    {
    }
    public virtual DbSet<Concilio> Concilios { get; set; }
    public virtual DbSet<Direccione> Direcciones { get; set; }
    public virtual DbSet<EstadosCivile> EstadosCiviles { get; set; }
    public virtual DbSet<Iglesia> Iglesias { get; set; }
    public virtual DbSet<Miembro> Miembros { get; set; }
    public virtual DbSet<Profecione> Profeciones { get; set; }
    public virtual DbSet<RedesSociale> RedesSociales { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-T3S73U1\\SQLEXPRESS;Database=Db_Iglesia;Trusted_Connection=True;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.ApplyConfiguration(new ConciliosConfiguration());
        modelBuilder.ApplyConfiguration(new DireccioneConfiguration());
        modelBuilder.ApplyConfiguration(new EstadosCivileConfiguration());
        modelBuilder.ApplyConfiguration(new IglesiaConsiguration());
        modelBuilder.ApplyConfiguration(new MiembroConfiguration());
        modelBuilder.ApplyConfiguration(new ProfecioneConfiguration());
        modelBuilder.ApplyConfiguration(new RedesSocialesConfiguration());

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
