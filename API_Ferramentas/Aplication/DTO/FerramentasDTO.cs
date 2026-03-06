using API_Ferramentas.Domain.Enum;

namespace API_Ferramentas.Aplication.DTO
{
    public class FerramentasDTO
    {
        public int Id { get; set; }
        public EnumFerramentas TiposdeFerramentas { get; set; }
        public string Nome { get; set; }
        public string Marca { get; set; }
        public int Milimetragem { get; set; }
        public DateTime DataRetiragem { get; set; }
        public DateTime DataDevolucao { get; set; }
    }
}
