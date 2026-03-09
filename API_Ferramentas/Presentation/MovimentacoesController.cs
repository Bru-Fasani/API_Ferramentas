using API_Ferramentas.Aplication.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Ferramentas.Presentation
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovimentacoesController : ControllerBase
    {
        [HttpGet("Listar Movimentações")]
        public ActionResult ListarMovimentacoes()
        {
            return Ok("Movimentações");
        }

        [HttpPost("Criar nova Movimentação")]
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

        [HttpPut("Atualizar Movimentação")]
        public ActionResult AtualizarMovimentacao(MovimentacaoDTO mov)
        {
            var movimentacaoAtualizada = new MovimentacaoDTO
            {
                IdFerramenta = mov.IdFerramenta,
                TipoMovimentacao = mov.TipoMovimentacao,
                Responsavel = mov.Responsavel,
                DataMovimentacao = mov.DataMovimentacao
            };
            return Ok("Movimentação atualizada");
        }

       [HttpDelete("Deletar Movimentação")]
        public ActionResult DeletarMovimentacao(int Id)
        {
            return Ok("Movimentação deletada com sucesso!");
        }


    }
}
