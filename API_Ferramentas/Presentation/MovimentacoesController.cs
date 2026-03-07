using API_Ferramentas.Aplication.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Ferramentas.Presentation
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovimentacoesController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            return Ok("Movimentações");
        }

        [HttpPost]
        public ActionResult CriarNovaRetiradaDeFerramentas(MovimentacaoDTO mov)
        {
            var novaMovimentacao = new MovimentacaoDTO
            {
                IdFerramenta = mov.IdFerramenta,
                TipoMovimentacao = mov.TipoMovimentacao,
                Responsavel = mov.Responsavel,
                DataMovimentacao = mov.DataMovimentacao
            };

            return Ok("Movimentação criada");
        }


    }
}
