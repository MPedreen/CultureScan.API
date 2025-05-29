using CultureScan.Domain.Perguntas;
using CultureScan.Infra.Repositories.Abstractions.Perguntas;
using CultureScan.Infra.Repositories.Context;
using CultureScan.Infra.Repositories.Repositories.Base;

namespace CultureScan.Infra.Repositories.Repositories.Perguntas;

public class CorporativoRepository : Repository<Corporativo>, ICorporativoRepository
{
    public CorporativoRepository(CultureScanContext context) : base(context.Corporativos, context)
    {
    }
}
