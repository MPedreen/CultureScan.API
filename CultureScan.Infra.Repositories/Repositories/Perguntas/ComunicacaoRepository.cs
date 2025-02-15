using CultureScan.Domain.Perguntas;
using CultureScan.Infra.Repositories.Abstractions.Perguntas;
using CultureScan.Infra.Repositories.Context;

namespace CultureScan.Infra.Repositories.Repositories.Perguntas;

public class ComunicacaoRepository : AbstractRepository<Comunicacao>, IComunicacaoRepository
{
    public ComunicacaoRepository(CultureScanContext context) : base(context.Comunicacoes, context)
    {
    }
}
