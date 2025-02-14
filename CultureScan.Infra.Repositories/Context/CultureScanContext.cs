using CultureScan.Domain.Perguntas;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace CultureScan.Infra.Repositories.Context;
public class CultureScanContext : DbContext
{
    public DbSet<Pergunta> Perguntas { get; set; }

    public CultureScanContext(DbContextOptions<CultureScanContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
        => builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
}