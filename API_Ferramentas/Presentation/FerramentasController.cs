using API_Ferramentas.Aplication.DTO;
using API_Ferramentas.Infrastructure.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace API_Ferramentas.Presentation
{
    [Route("api/[controller]")]
    [ApiController]
    public class FerramentasController : ControllerBase
    {
        private readonly IFerramentaRepository _ferramentaRepository;
        public FerramentasController(IFerramentaRepository repository)
        {
              _ferramentaRepository = repository;
        }


        [HttpGet("Obter Ferramenta Por Categoria")]
        public ActionResult ObterFerramentaPorCategoria(string categoria)
        {
            return Ok($"Lista de ferramentas da categoria {categoria} retornada com sucesso!");
        }

        [HttpGet("Obter Ferramenta Por Nome")]
        public ActionResult ObterFerramentaPorNome(string nome)
        {
            return Ok($"Lista de ferramentas com o nome {nome} retornada com sucesso!");
        }

        [HttpGet("Obter Ferramenta Por Id")]
        public async Task<ActionResult> ObterFerramentaPorId(int Id)
        {
           return Ok($"Ferramenta com Id {Id} retornada com sucesso!");
        }


        [HttpPost("Cadastrar Nova Ferramenta")]
        public async Task<ActionResult> CadastrarFerramenta(FerramentasDTO toolsDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            //var novaferramenta = await _ferramentaRepository.Adicionar();  -> Não aceita o parâmetro

            return Ok("Ferramenta cadastrada com sucesso!");
        }

        [HttpPut("Atualizar Ferramenta")]
        public ActionResult AtualizarFerramenta(FerramentasDTO toolsDTO)
        {
            return Ok("Ferramenta atualizada com sucesso!");
        }

        [HttpDelete("Deletar Ferramenta")]
        public ActionResult DeletarFerramenta(int Id)
        {
            return Ok("Ferramenta deletada com sucesso!");
        }
      
    }
}
