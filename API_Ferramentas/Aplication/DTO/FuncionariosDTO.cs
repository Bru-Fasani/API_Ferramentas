using API_Ferramentas.Domain.Enum;

namespace API_Ferramentas.Aplication.DTO
{
    public class FuncionariosDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public EnumFuncionarios Cargo { get; set; }
    }
}
