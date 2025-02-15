using CultureScan.Domain.Perguntas;
using CultureScan.Infra.Repositories.Abstractions.Perguntas;
using CultureScan.Infra.Repositories.Context;

namespace CultureScan.Infra.Repositories.Repositories.Perguntas;

public class ChefiaRepository : AbstractRepository<Chefia>, IChefiaRepository
{
    public ChefiaRepository(CultureScanContext context) : base(context.Chefias, context)
    {
    }
}
