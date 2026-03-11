using API_Ferramentas.Domain.Entities;

namespace API_Ferramentas.Infrastructure.Interface
{
    public interface IFerramentaRepository
    {
        //Criar
        Task<Ferramentas> Adicionar(Ferramentas ferramentas);

        //Listar ou Obter
        Task<Ferramentas> ObterFerramentaPorId(int id);
        Task<IEnumerable<Ferramentas>> ObterFerramentaPorCategoria(string categoria);
        Task<IEnumerable<Ferramentas>> ObterFerramentaPorNome(string Nome);

        //Atualizar
        Task<Ferramentas> Atualizar(Ferramentas ferramentas);

        //Deletar
        Task<bool> Remover(int id);
        Task<bool> Desativar(int id);

    }
}
