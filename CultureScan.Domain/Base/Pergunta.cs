using CultureScan.Domain.Perguntas;

namespace CultureScan.Domain.Base
{
    public abstract class Pergunta : Entity<Pergunta>
    {
        public abstract string Categoria { get; }
        public abstract ICollection<PerguntaDto> ObterPerguntas();
    }
}
