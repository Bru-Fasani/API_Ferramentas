using API_Ferramentas.Aplication.DTO;
using API_Ferramentas.Aplication.Interfaces;
using API_Ferramentas.Infrastructure.Data;
using API_Ferramentas.Infrastructure.Interface;

namespace API_Ferramentas.Aplication.Services
{
    public class MovimentacaoService : IMovimentacaoService
    {
        private readonly IMovRepository _movRepository;
     
        public MovimentacaoService(IMovRepository movRepository)
        {
            _movRepository = movRepository;  
        }

        public async Task CriarNovaRetiradaDeFerramentas()
        {
            var novaMovimentacao = new MovimentacaoDTO
            {
                IdFerramenta = 1,
               // TipoMovimentacao = 2, -> problemas em identificar o EnumMovimentacao 
                Responsavel = "João",
                DataMovimentacao = DateTime.UtcNow
            };
            // await -> Ainda sem Repository
        }


    }
}
