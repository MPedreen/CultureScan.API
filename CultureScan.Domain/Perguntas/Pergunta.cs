using CultureScan.Domain.Base;

namespace CultureScan.Domain.Perguntas
{
    public abstract class Pergunta : Entity<Pergunta>
    {
        public abstract string Categoria { get; }
        public string Descricao { get; }
        public abstract ICollection<PerguntaDto> ObterPerguntas();
    }
}
