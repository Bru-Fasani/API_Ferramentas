using API_Ferramentas.Domain.Enum;
using System.ComponentModel.DataAnnotations;

namespace API_Ferramentas.Aplication.DTO
{
    public class FerramentasDTO
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public EnumFerramentas Categoria { get; set; }

        [Required]
        [MaxLength(20)]
        public string Nome { get; set; }

        [Required]
        [MaxLength(20)]
        public string Marca { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "O valor deve ser positivo.")]
        public decimal Milimetragem { get; set; }

        [Required]
        [MaxLength(40)]
        public string Localizacao { get; set; }

    }
}
