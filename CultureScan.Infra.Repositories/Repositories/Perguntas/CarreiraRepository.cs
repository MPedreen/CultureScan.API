using CultureScan.Domain.Perguntas;
using CultureScan.Infra.Repositories.Abstractions.Perguntas;
using CultureScan.Infra.Repositories.Context;

namespace CultureScan.Infra.Repositories.Repositories.Perguntas;

public class CarreiraRepository : AbstractRepository<Carreira>, ICarreiraRepository
{
    public CarreiraRepository(CultureScanContext context) : base(context.Carreiras, context)
    {
    }
}
