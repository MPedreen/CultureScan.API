using CultureScan.Domain.Perguntas;
using CultureScan.Infra.Repositories.Abstractions.Perguntas;
using CultureScan.Infra.Repositories.Context;

namespace CultureScan.Infra.Repositories.Repositories.Perguntas;

public class CorporativoRepository : AbstractRepository<Corporativo>, ICorporativoRepository
{
    public CorporativoRepository(CultureScanContext context) : base(context.Corporativos, context)
    {
    }
}
