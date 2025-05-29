using CultureScan.Domain.Perguntas;
using CultureScan.Infra.Repositories.Abstractions.Perguntas;
using CultureScan.Infra.Repositories.Context;
using CultureScan.Infra.Repositories.Repositories.Base;

namespace CultureScan.Infra.Repositories.Repositories.Perguntas;

public class ProcessoRepository : Repository<Processo>, IProcessoRepository
{
    public ProcessoRepository(CultureScanContext context) : base(context.Processos, context)
    {
    }
}
