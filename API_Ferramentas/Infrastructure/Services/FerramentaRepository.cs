using API_Ferramentas.Domain.Entities;
using API_Ferramentas.Infrastructure.Data;
using API_Ferramentas.Infrastructure.Interface;
using Microsoft.EntityFrameworkCore;

namespace API_Ferramentas.Infrastructure.Services
{
    public class FerramentaRepository : IFerramentaRepository
    {
        private readonly AppDbContext _context;
        public FerramentaRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Ferramentas> Adicionar(Ferramentas ferramenta)
        {
            
            await _context.Ferramentas.AddAsync(ferramenta);
            await _context.SaveChangesAsync();

            return ferramenta;
        }

        
       /* public async Task<IEnumerable<Ferramentas>> ObterFerramentaPorCategoria(string categoria);
        {
           return await _context.Ferramentas
            .Where(f => f.Categoria)
            .OrderBy(f => f.Nome)
            .ToListAsync();
        
        }
        public async Task<IEnumerable<Ferramentas>> ObterFerramentaPorNome(string nome);
        { }
        public async Task<Ferramentas> ObterFerramentaPorId(int id);
        { }


}
}
