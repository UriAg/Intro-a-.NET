using Microsoft.EntityFrameworkCore;
using CodeProject.Models;

namespace CodeProject.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Empleado> Empleados { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Empleado>(table =>
            {
                table.HasKey(col => col.IdEmpleado);

                table.Property(col => col.IdEmpleado)
                .UseIdentityColumn()
                .ValueGeneratedOnAdd();

                table.Property(col => col.NombreCompleto).HasMaxLength(50);
                table.Property(col => col.Correo).HasMaxLength(50);

            });

            modelBuilder.Entity<Empleado>().ToTable("Empleado");

        }
    }
}
