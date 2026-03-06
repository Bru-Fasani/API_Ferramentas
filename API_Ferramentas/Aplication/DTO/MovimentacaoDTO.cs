using API_Ferramentas.Domain.Enum;

namespace API_Ferramentas.Aplication.DTO
{
    public class MovimentacaoDTO
    {
        public int Id { get; set; }
        public int IdFerramenta { get; set; }
        public EnumMovimentacao TipoMovimentacao { get; set; }
        public string Responsavel { get; set; }
        public DateTime DataMovimentacao { get; set; }
    }
}
