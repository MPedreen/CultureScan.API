using CultureScan.Domain.Perguntas;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace CultureScan.Infra.Repositories.Configurations.Perguntas;

public class ProcessoConfiguration : IEntityTypeConfiguration<Processo>
{
    public void Configure(EntityTypeBuilder<Processo> processos)
    {
        processos.HasKey(c => c.Id);

        processos.Property(c => c.Descricao)
            .IsRequired();

        processos.HasData(
            new Processo { Descricao = "Como você avalia o nível de serviço que a empresa oferece aos seus clientes em termos de qualidade e eficiência?" },
            new Processo { Descricao = "Na sua opinião, qual é o nível de satisfação dos clientes com os serviços prestados pela empresa?" },
            new Processo { Descricao = "Você sente que tem autonomia suficiente para oferecer um atendimento de excelência aos clientes, dentro das suas responsabilidades?" },
            new Processo { Descricao = "Você percebe que a INFIS tem um foco consistente e eficaz na busca pela satisfação do cliente em todas as suas ações e decisões?" }
        );
    }
}
