using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using CultureScan.Domain.Perguntas;

namespace CultureScan.Infra.Repositories.Configurations
{
    public class PerguntaConfiguration : IEntityTypeConfiguration<Pergunta>
    {
        public void Configure(EntityTypeBuilder<Pergunta> perguntas)
        {
            perguntas
                .HasKey(key => key.Id);

            perguntas
                .Property(prop => prop.Descricao)
                .IsRequired();
        }
    }
}
