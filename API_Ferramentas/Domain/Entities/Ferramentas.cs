
using API_Ferramentas.Domain.Enum;
using System.ComponentModel.DataAnnotations;

namespace API_Ferramentas.Domain.Entities
{
    public class Ferramentas
    {
        [Key]
        public int Id { get; set; }
        public EnumFerramentas Categoria { get; set; }
        public string Nome { get; set; }
        public string Marca { get; set; }
        public decimal Milimetragem { get; set; }
        public string Localizacao { get; set; }
       


    }
}
