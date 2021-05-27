using Microsoft.EntityFrameworkCore;

namespace ApiCartoes.Models
{
    public class CartoesContext : DbContext
    {
        public CartoesContext(DbContextOptions<CartoesContext> options)
            : base(options)
        {
        }
        public DbSet<Cartao> Cartoes { get; set; }
    }
}