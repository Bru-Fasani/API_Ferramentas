using API_Ferramentas.Domain.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Ferramentas.Domain.Entities
{
    public class Movimentacao
    {
        [Key]
        public int Id { get; set; }

        public int IdFerramenta { get; set; }
        public Ferramentas Ferramenta { get; set; }

        public EnumMovimentacao TipoMovimentacao { get; set; } 
        public string Responsavel { get; set; }

        private DateTime _dataMovimentacao;
        public DateTime DataMovimentacao
        { 
            get => _dataMovimentacao;
            set => _dataMovimentacao = DateTime.SpecifyKind(value, DateTimeKind.Utc);
        }

       
    }
}
