using CultureScan.Domain.Base;

namespace CultureScan.Domain.Perguntas
{
    public class Remuneracao : Pergunta
    {
        public override string Categoria => "remuneracao";

        public override ICollection<PerguntaDto> ObterPerguntas() => new List<PerguntaDto>
        {
            new() { Pergunta = "Você está satisfeito com a cobertura e qualidade do plano de assistência médica, que se estende aos seus dependentes (filhos)?" },
            new() { Pergunta = "Você está satisfeito com a cobertura e qualidade do plano de assistência odontológica, que também abrange seus dependentes (filhos) - se aplicável?" },
            new() { Pergunta = "Você considera o seguro de vida oferecido pela empresa adequado e satisfatório para suas necessidades e de seus dependentes?" },
            new() { Pergunta = "Você considera que o benefício de alimentação (Flash Benefícios) e a flexibilidade oferecida atendem às suas necessidades e expectativas?" },
            new() { Pergunta = "O benefício do Gympass, que oferece acesso a academias e atividades físicas, atende suas expectativas e contribui para o seu bem-estar?" },
            new() { Pergunta = "Como você avalia a sua remuneração em comparação aos demais colaboradores da empresa que ocupam cargos similares?" },
            new() { Pergunta = "Você considera que a sua remuneração está alinhada com os profissionais que atuam nas mesmas funções em outras empresas do setor?" },
            new() { Pergunta = "Você está satisfeito com o sistema de bonificação por resultados oferecido pela empresa?" },
            new() { Pergunta = "Você considera que o percentual de bonificação é definido e apresentado de maneira clara e satisfatória?" }
        };
    }
}
