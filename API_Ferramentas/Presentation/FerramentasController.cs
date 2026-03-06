using API_Ferramentas.Aplication.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Ferramentas.Presentation
{
    [Route("api/[controller]")]
    [ApiController]
    public class FerramentasController : ControllerBase
    {

        [HttpPost]
        public ActionResult CadastrarFerramenta(FerramentasDTO toolsDTO)
        {
            return Ok("Ferramenta cadastrada com sucesso!");
        }

        [HttpPut]
        public ActionResult AtualizarFerramenta(FerramentasDTO toolsDTO)
        {
            return Ok("Ferramenta atualizada com sucesso!");
        }

        [HttpDelete]
        public ActionResult DeletarFerramenta(int Id)
        {
            return Ok("Ferramenta deletada com sucesso!");
        }
      
    }
}
