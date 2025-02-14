namespace CultureScan.Domain.Base;

public abstract class Entity<T> where T : Entity<T>
{
    public Guid Id { get; protected set; }
    public DateTime DataCriacao { get; protected set; }
    public DateTime DataUltimaAtualizacao { get; protected set; }

    protected Entity()
    {
        Id = Guid.NewGuid();
        DataCriacao = DateTime.UtcNow;
        DataUltimaAtualizacao = DateTime.UtcNow;
    }
}
