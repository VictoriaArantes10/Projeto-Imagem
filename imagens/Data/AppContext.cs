using imagens.Models;
using Microsoft.EntityFrameworkCore;

namespace imagens.Data
{
    public class AppContext : DbContext
    {

        public AppContext(DbContextOptions<AppContext> options) : base(options)
        {

        }

        public DbSet<Produto> Produtos { get; set; }
    }
}
