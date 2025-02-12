using CultureScan.Domain.Base;

namespace CultureScan.Domain.Perguntas
{
    public class Comunicacao : Pergunta
    {
        public override string Categoria => "comunicacao";

        public override ICollection<PerguntaDto> ObterPerguntas() => new()
        {
            new PerguntaDto { Pergunta = "Você tem uma compreensão clara dos objetivos da sua área?" },
            new PerguntaDto { Pergunta = "As suas responsabilidades no cargo estão bem definidas?" },
            new PerguntaDto { Pergunta = "Você sente que tem liberdade para dar sugestões?" },
            new PerguntaDto { Pergunta = "Como avalia a comunicação com sua chefia?" }
        };
    }
}
