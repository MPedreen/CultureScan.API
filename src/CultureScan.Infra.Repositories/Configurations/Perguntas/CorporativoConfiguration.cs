using CultureScan.Domain.Perguntas;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace CultureScan.Infra.Repositories.Configurations.Perguntas;

public class CorporativoConfiguration : IEntityTypeConfiguration<Corporativo>
{
    public void Configure(EntityTypeBuilder<Corporativo> corporativos)
    {
        corporativos.HasKey(c => c.Id);

        corporativos.Property(c => c.Descricao)
            .IsRequired();

        corporativos.HasData(
            new Corporativo { Descricao = "Motivos Pessoais" },
            new Corporativo { Descricao = "Insatisfação com a remuneração e benefícios" },
            new Corporativo { Descricao = "Problemas com a liderança ou gestão" },
            new Corporativo { Descricao = "Ambiente de trabalho tóxico ou conflitos interpessoais" },
            new Corporativo { Descricao = "Falta de oportunidades de crescimento e desenvolvimento" },
            new Corporativo { Descricao = "Falta de reconhecimento e valorização profissional" },
            new Corporativo { Descricao = "Excesso de carga de trabalho ou pressão" },
            new Corporativo { Descricao = "Desejo de buscar novos desafios profissionais em outra empresa" },
            new Corporativo { Descricao = "Desalinhamento com os valores e cultura da empresa" },
            new Corporativo { Descricao = "Outro (por favor, especifique)" }
        );
    }
}
