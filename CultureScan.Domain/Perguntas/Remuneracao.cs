using CultureScan.Domain.Base;

namespace CultureScan.Domain.Perguntas
{
    public class Remuneracao : Pergunta
    {
        public override string Categoria => "remuneracao";

        public override ICollection<PerguntaDto> ObterPerguntas() => new List<PerguntaDto>
        {
            new() { Pergunta = "Você está satisfeito com os benefícios oferecidos pela empresa?" },
            new() { Pergunta = "Você considera sua remuneração justa em comparação com colaboradores de cargos similares na empresa?" },
            new() { Pergunta = "Você acredita que sua remuneração está alinhada com o mercado para sua função?" },
        };
    }
}
