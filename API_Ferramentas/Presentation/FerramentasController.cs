using API_Ferramentas.Aplication.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Ferramentas.Presentation
{
    [Route("api/[controller]")]
    [ApiController]
    public class FerramentasController : ControllerBase
    {
        [HttpGet("Listar Todas As Ferramentas")]
        public ActionResult ListarFerramentas()
        {
            return Ok("Lista de ferramentas retornada com sucesso!");
        }

        [HttpGet("Listar Ferramenta Por Categoria")]
        public ActionResult ListarFerramentaPorCategoria(string categoria)
        {
            return Ok($"Lista de ferramentas da categoria {categoria} retornada com sucesso!");
        }

        [HttpGet("Listar Ferramenta Por Id")]
        public ActionResult ListarFerramentaPorId(int Id)
        {
            return Ok($"Ferramenta com Id {Id} retornada com sucesso!");
        }


        [HttpPost("Cadastrar Nova Ferramenta")]
        public ActionResult CadastrarFerramenta(FerramentasDTO toolsDTO)
        {
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
