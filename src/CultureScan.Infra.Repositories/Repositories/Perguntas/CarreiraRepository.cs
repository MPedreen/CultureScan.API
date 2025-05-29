using CultureScan.Domain.Perguntas;
using CultureScan.Infra.Repositories.Abstractions.Perguntas;
using CultureScan.Infra.Repositories.Context;
using CultureScan.Infra.Repositories.Repositories.Base;

namespace CultureScan.Infra.Repositories.Repositories.Perguntas;

public class CarreiraRepository : Repository<Carreira>, ICarreiraRepository
{
    public CarreiraRepository(CultureScanContext context) : base(context.Carreiras, context)
    {
    }
}
