using CultureScan.Domain.Enums;

namespace CultureScan.Domain.DTOs
{
    public class IntroducaoDTO
    {
        public string Setor { get; set; }
        public TempoDeTrabalhoEnum TempoDeTrabalhoEnum { get; set; }
        public string Regiao { get; set; }
    }
}
