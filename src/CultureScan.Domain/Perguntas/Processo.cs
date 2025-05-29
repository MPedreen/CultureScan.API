using CultureScan.Domain.Base;

namespace CultureScan.Domain.Perguntas;

public class Processo : Entity<Processo>
{
    public string Descricao { get; set; }
}
