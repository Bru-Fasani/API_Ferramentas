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


    }
}
