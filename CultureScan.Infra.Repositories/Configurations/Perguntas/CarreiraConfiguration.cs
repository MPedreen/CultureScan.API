using CultureScan.Domain.Perguntas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CultureScan.Infra.Repositories.Configurations.Perguntas;

public class CarreiraConfiguration : IEntityTypeConfiguration<Carreira>
{
    public void Configure(EntityTypeBuilder<Carreira> carreiras)
    {
        carreiras.HasKey(c => c.Id);

        carreiras.Property(c => c.Descricao)
            .IsRequired();

        carreiras.HasData(
            new Carreira { Descricao = "Você tem um plano de carreira definido dentro da empresa, com caminhos claros para seu desenvolvimento e progressão?" },
            new Carreira { Descricao = "Você sabe quais habilidades e competências precisa desenvolver para avançar na sua carreira dentro da empresa?" },
            new Carreira { Descricao = "A empresa oferece um programa de desenvolvimento claro e estruturado para apoiar sua progressão de carreira?" },
            new Carreira { Descricao = "Você sente que tem o suporte necessário para esclarecer dúvidas sobre seu desenvolvimento profissional e suas oportunidades de carreira?" },
            new Carreira { Descricao = "Você tem uma visão clara sobre as oportunidades de crescimento interno e como pode alcançá-las dentro da empresa?" },
            new Carreira { Descricao = "O processo de feedback e avaliação de desempenho é claro e eficaz para ajudá-lo a melhorar seu desempenho e alcançar seus objetivos profissionais?" },
            new Carreira { Descricao = "Você acredita que a empresa é transparente em relação às contratações de novos colegas e às oportunidades de promoção interna?" },
            new Carreira { Descricao = "Você considera que o volume de trabalho que você recebe é adequado ao tempo disponível na sua jornada de trabalho?" }
        );
    }
}
