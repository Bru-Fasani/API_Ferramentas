using API_Ferramentas.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace API_Ferramentas.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
            public DbSet<Ferramentas> Ferramentas { get; set; }
            public DbSet<Movimentacao> Movimentacoes { get; set; }
            public DbSet<Funcionarios> Funcionarios { get; set; }
        
    }
}
