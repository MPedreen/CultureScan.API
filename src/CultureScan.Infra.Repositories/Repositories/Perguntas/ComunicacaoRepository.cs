﻿using CultureScan.Domain.Perguntas;
using CultureScan.Infra.Repositories.Abstractions.Perguntas;
using CultureScan.Infra.Repositories.Context;
using CultureScan.Infra.Repositories.Repositories.Base;

namespace CultureScan.Infra.Repositories.Repositories.Perguntas;

public class ComunicacaoRepository : Repository<Comunicacao>, IComunicacaoRepository
{
    public ComunicacaoRepository(CultureScanContext context) : base(context.Comunicacoes, context)
    {
    }
}
