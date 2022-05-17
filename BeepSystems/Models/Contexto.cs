using Microsoft.EntityFrameworkCore;

namespace BeepSystems.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes)
        {

        }
    }
}
