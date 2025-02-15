using CultureScan.Domain.Perguntas;
using CultureScan.Infra.Repositories.Abstractions.Perguntas;
using CultureScan.Infra.Repositories.Context;

namespace CultureScan.Infra.Repositories.Repositories.Perguntas;

public class ProcessoRepository : AbstractRepository<Processo>, IProcessoRepository
{
    public ProcessoRepository(CultureScanContext context) : base(context.Processos, context)
    {
    }
}
