using Microsoft.EntityFrameworkCore;

namespace facturacion.Models {
    public class MyDbContext : DbContext {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Producto> Productos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Cliente>().HasKey(c=>c.idCliente);
            modelBuilder.Entity<Producto>().HasKey(c=>c.idProducto);
        }
    }
}
