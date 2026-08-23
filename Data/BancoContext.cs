using Microsoft.EntityFrameworkCore;
using WebBarber.Models;

namespace WebBarber.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }

        public DbSet<ClientesModel> Clientes { get; set; }

        public DbSet<ServicosModel> Servicos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ServicosModel>()
                .Property(x => x.Preco)
                .HasPrecision(18, 2);
        }
    }
}