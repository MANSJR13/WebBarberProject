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

    }
}
