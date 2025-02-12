using CultureScan.Domain.Base;

namespace CultureScan.Domain.Perguntas
{
    public class Comunicacao : Pergunta
    {
        public override string Categoria => "comunicacao";

        public override ICollection<PerguntaDto> ObterPerguntas() => new List<PerguntaDto>
        {
            new() { Pergunta = "Você tem uma compreensão clara dos objetivos da sua área e de como eles se alinham aos objetivos gerais da empresa?" },
            new() { Pergunta = "As suas responsabilidades no cargo que ocupa estão bem definidas e são claras para você?" },
            new() { Pergunta = "Você sente que tem liberdade e oportunidades para dar sugestões e fazer críticas construtivas dentro do seu setor?" },
            new() { Pergunta = "Como você avalia a comunicação com sua chefia e com os demais gestores da empresa?" },
            new() { Pergunta = "Você considera que a comunicação entre os diferentes setores da empresa é eficiente e eficaz?" },
            new() { Pergunta = "Você tem confiança nos planos estratégicos, nas decisões e na direção que a empresa está tomando?" },
            new() { Pergunta = "Você confia que a empresa adota práticas éticas e transparentes em suas operações e decisões?" },
            new() { Pergunta = "Você sente que tem oportunidades suficientes para sugerir melhorias nos processos ou identificar novas oportunidades de negócios dentro da empresa?" },
            new() { Pergunta = "Você se sente tratado com respeito e de forma justa pelos gestores da empresa?" },
            new() { Pergunta = "O código de conduta da empresa está claro para você e é respeitado nos relacionamentos internos?" },
            new() { Pergunta = "Você considera que os comunicados internos da empresa são eficazes para manter todos os colaboradores bem informados?" },
            new() { Pergunta = "Como você avalia o relacionamento interno entre os colaboradores da empresa? Há um ambiente de cooperação?" }
        };
    }
}
