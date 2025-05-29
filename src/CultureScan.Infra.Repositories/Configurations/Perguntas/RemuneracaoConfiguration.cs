using CultureScan.Domain.Perguntas;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace CultureScan.Infra.Repositories.Configurations.Perguntas;

public class RemuneracaoConfiguration : IEntityTypeConfiguration<Remuneracao>
{
    public void Configure(EntityTypeBuilder<Remuneracao> remuneracoes)
    {
        remuneracoes.HasKey(c => c.Id);

        remuneracoes.Property(c => c.Descricao)
            .IsRequired();

        remuneracoes.HasData(
            new Remuneracao { Descricao = "Você está satisfeito com os benefícios oferecidos pela empresa?" },
            new Remuneracao { Descricao = "Você considera sua remuneração justa em comparação com colaboradores de cargos similares na empresa?" },
            new Remuneracao { Descricao = "Você acredita que sua remuneração está alinhada com o mercado para sua função?" }
        );
    }
}
