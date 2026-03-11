using API_Ferramentas.Domain.Enum;
using System.ComponentModel.DataAnnotations;

namespace API_Ferramentas.Domain.Entities
{
    public class Funcionarios
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }
        [Required]
        public EnumFuncionarios Cargo { get; set; }
    }
}
