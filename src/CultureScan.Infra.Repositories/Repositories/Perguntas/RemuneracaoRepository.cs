using CultureScan.Domain.Perguntas;
using CultureScan.Infra.Repositories.Abstractions.Perguntas;
using CultureScan.Infra.Repositories.Context;
using CultureScan.Infra.Repositories.Repositories.Base;

namespace CultureScan.Infra.Repositories.Repositories.Perguntas;

public class RemuneracaoRepository : Repository<Remuneracao>, IRemuneracaoRepository
{
    public RemuneracaoRepository(CultureScanContext context) : base(context.Remuneracoes, context)
    {
    }
}
