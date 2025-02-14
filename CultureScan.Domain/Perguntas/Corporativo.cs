namespace CultureScan.Domain.Perguntas
{
    public class Corporativo : Pergunta
    {
        public override string Categoria => "corporativo";

        public override ICollection<PerguntaDto> ObterPerguntas() => new List<PerguntaDto>
        {
            new() { Pergunta = "Motivos Pessoais" },
            new() { Pergunta = "Insatisfação com a remuneração e benefícios" },
            new() { Pergunta = "Problemas com a liderança ou gestão" },
            new() { Pergunta = "Ambiente de trabalho tóxico ou conflitos interpessoais" },
            new() { Pergunta = "Falta de oportunidades de crescimento e desenvolvimento" },
            new() { Pergunta = "Falta de reconhecimento e valorização profissional" },
            new() { Pergunta = "Excesso de carga de trabalho ou pressão" },
            new() { Pergunta = "Desejo de buscar novos desafios profissionais em outra empresa" },
            new() { Pergunta = "Desalinhamento com os valores e cultura da empresa" },
            new() { Pergunta = "Outro (por favor, especifique)" }
        };
    }
}
