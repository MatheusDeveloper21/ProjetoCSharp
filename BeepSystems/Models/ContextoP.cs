using Microsoft.EntityFrameworkCore;

namespace BeepSystems.Models
{
    public class ContextoP : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        public ContextoP(DbContextOptions<ContextoP> opcoes) : base(opcoes)
        {

        }
    }
}
