namespace CultureScan.Domain.Perguntas;

public class Carreira : Pergunta
{
    public override string Categoria => "carreira";
    public override IReadOnlyList<PerguntaDto> ObterPerguntas() => _perguntas;

    private static readonly IReadOnlyList<PerguntaDto> _perguntas = new List<PerguntaDto>
    {
        new() { Pergunta = "Você tem um plano de carreira definido dentro da empresa, com caminhos claros para seu desenvolvimento e progressão?" },
        new() { Pergunta = "Você sabe quais habilidades e competências precisa desenvolver para avançar na sua carreira dentro da empresa?" },
        new() { Pergunta = "A empresa oferece um programa de desenvolvimento claro e estruturado para apoiar sua progressão de carreira?" },
        new() { Pergunta = "Você sente que tem o suporte necessário para esclarecer dúvidas sobre seu desenvolvimento profissional e suas oportunidades de carreira?" },
        new() { Pergunta = "Você tem uma visão clara sobre as oportunidades de crescimento interno e como pode alcançá-las dentro da empresa?" },
        new() { Pergunta = "O processo de feedback e avaliação de desempenho é claro e eficaz para ajudá-lo a melhorar seu desempenho e alcançar seus objetivos profissionais?" },
        new() { Pergunta = "Você acredita que a empresa é transparente em relação às contratações de novos colegas e às oportunidades de promoção interna?" },
        new() { Pergunta = "Você considera que o volume de trabalho que você recebe é adequado ao tempo disponível na sua jornada de trabalho?" }
    };
}
