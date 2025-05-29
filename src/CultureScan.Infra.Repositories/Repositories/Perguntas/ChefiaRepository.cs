using CultureScan.Domain.Perguntas;
using CultureScan.Infra.Repositories.Abstractions.Perguntas;
using CultureScan.Infra.Repositories.Context;
using CultureScan.Infra.Repositories.Repositories.Base;

namespace CultureScan.Infra.Repositories.Repositories.Perguntas;

public class ChefiaRepository : Repository<Chefia>, IChefiaRepository
{
    public ChefiaRepository(CultureScanContext context) : base(context.Chefias, context)
    {
    }
}
