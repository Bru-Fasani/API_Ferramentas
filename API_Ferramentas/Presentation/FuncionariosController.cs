using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Ferramentas.Presentation
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionariosController : ControllerBase
    {
        [HttpGet("Todos Os Funcionários")]
        public ActionResult ListarTodosFuncionarios()
        {
            return Ok("Funcionários");
        }


        [HttpPost("Cadastrar Funcionário")]
        public ActionResult CadastrarFuncionario()
        {
            return Ok("Funcionário cadastrado com sucesso!");
        }

        [HttpPut("Atualizar Funcionário")]
        public ActionResult AtualizarFuncionario()
        {
            return Ok("Funcionário atualizado com sucesso!");
        }

        [HttpDelete ("Deletar Funcionário")]
        public ActionResult DeletarFuncionario(int Id)
        {
            return Ok("Funcionário deletado com sucesso!");
        }

    }
}
