using Microsoft.EntityFrameworkCore;
using RegistroPedidosDetalle.Models;

namespace RegistroPedidosDetalle.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Productos> Productos { get; set; }
        public DbSet<Suplidores> Suplidores { get; set; }
        public DbSet<Ordenes> Ordenes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = C:\BasesDeDatosAp2\RegistroPrestamos.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Suplidores>().HasData(new Suplidores
            {
                SuplidorId = 1,
                Nombres="Induveca"
            });

            modelBuilder.Entity<Suplidores>().HasData(new Suplidores
            {
                SuplidorId = 2,
                Nombres = "Rica"
            });

            modelBuilder.Entity<Productos>().HasData(new Productos
            {
                ProductoId = 1,
                Descripcion = "Salami Super especial",
                Costo = 250,
                Inventario = 10
            });

            modelBuilder.Entity<Productos>().HasData(new Productos
            {
                ProductoId = 2,
                Descripcion = "Carton de Leche",
                Costo = 60,
                Inventario = 15
            });


        }
    }
}
