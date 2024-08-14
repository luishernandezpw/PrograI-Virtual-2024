using Microsoft.EntityFrameworkCore;

namespace proyecto_final.Models {
    public class MyDbContext : DbContext{
        public MyDbContext() { }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Cliente>().HasKey(e => e.idCliente);
        }

    }
}
