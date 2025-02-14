namespace CultureScan.Domain.Perguntas
{
    public class Chefia : Pergunta
    {
        public override string Categoria => "chefia";

        public override ICollection<PerguntaDto> ObterPerguntas() => new List<PerguntaDto>
        {
            new() { Pergunta = "Você confia na competência técnica dos seus gestores diretos no seu setor?" },
            new() { Pergunta = "Você sente que é tratado com respeito por seus colegas e gestores no ambiente de trabalho?" },
            new() { Pergunta = "Você recebe feedback específico e construtivo sobre seu desempenho, que ajude no seu desenvolvimento profissional?" },
            new() { Pergunta = "Você percebe que todos os membros da equipe são tratados de maneira justa e igualitária por seus gestores?" },
            new() { Pergunta = "Você considera que o trabalho está sendo distribuído de forma justa entre os membros da equipe?" },
            new() { Pergunta = "Você acredita que a avaliação de seu desempenho profissional é justa e condizente com suas responsabilidades e entregas?" },
            new() { Pergunta = "Você confia nas decisões tomadas pelos gestores ou pelos sócios para garantir o sucesso da empresa e alcançar o crescimento proposto?" },
            new() { Pergunta = "Seus gestores respondem rapidamente às suas dúvidas e solicitações, ajudando você a realizar suas tarefas de maneira eficiente?" },
            new() { Pergunta = "Você considera que as respostas que recebe do seu gestor são de alta qualidade e assertivas, permitindo que você realize seu trabalho de forma eficaz?" },
            new() { Pergunta = "Você sente que seus gestores e os sócios ouvem atentamente suas opiniões e preocupações no ambiente de trabalho?" }
        };
    }
}
