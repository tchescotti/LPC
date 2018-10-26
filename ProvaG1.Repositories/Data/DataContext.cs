using Microsoft.EntityFrameworkCore;
using ProvaG1.Domain;

namespace ProvaG1.Repositories.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}

        public DbSet<Plano> Planos {get; set;}
        public DbSet<Cliente> Clientes {get; set;}
        public DbSet<Consulta> Consultas {get; set;}
    }
}