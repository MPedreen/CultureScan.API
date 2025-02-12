using CultureScan.Domain.Base;

namespace CultureScan.Domain.Perguntas
{
    public class Processos : Pergunta
    {
        public override string Categoria => "processos";

        public override ICollection<PerguntaDto> ObterPerguntas() => new List<PerguntaDto>
        {
            new() { Pergunta = "Como você avalia o nível de serviço que a empresa oferece aos seus clientes em termos de qualidade e eficiência?" },
            new() { Pergunta = "Na sua opinião, qual é o nível de satisfação dos clientes com os serviços prestados pela empresa?" },
            new() { Pergunta = "Você sente que tem autonomia suficiente para oferecer um atendimento de excelência aos clientes, dentro das suas responsabilidades?" },
            new() { Pergunta = "Você percebe que a INFIS tem um foco consistente e eficaz na busca pela satisfação do cliente em todas as suas ações e decisões?" }
        };
    }
}
