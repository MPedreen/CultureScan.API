using CultureScan.Domain.Perguntas;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace CultureScan.Infra.Repositories.Configurations.Perguntas;

public class ChefiaConfiguration : IEntityTypeConfiguration<Chefia>
{
    public void Configure(EntityTypeBuilder<Chefia> chefias)
    {
        chefias.HasKey(c => c.Id);

        chefias.Property(c => c.Descricao)
            .IsRequired();

        chefias.HasData(
            new Chefia { Descricao = "Você confia na competência técnica dos seus gestores diretos no seu setor?" },
            new Chefia { Descricao = "Você sente que é tratado com respeito por seus colegas e gestores no ambiente de trabalho?" },
            new Chefia { Descricao = "Você recebe feedback específico e construtivo sobre seu desempenho, que ajude no seu desenvolvimento profissional?" },
            new Chefia { Descricao = "Você percebe que todos os membros da equipe são tratados de maneira justa e igualitária por seus gestores?" },
            new Chefia { Descricao = "Você considera que o trabalho está sendo distribuído de forma justa entre os membros da equipe?" },
            new Chefia { Descricao = "Você acredita que a avaliação de seu desempenho profissional é justa e condizente com suas responsabilidades e entregas?" },
            new Chefia { Descricao = "Você confia nas decisões tomadas pelos gestores ou pelos sócios para garantir o sucesso da empresa e alcançar o crescimento proposto?" },
            new Chefia { Descricao = "Seus gestores respondem rapidamente às suas dúvidas e solicitações, ajudando você a realizar suas tarefas de maneira eficiente?" },
            new Chefia { Descricao = "Você considera que as respostas que recebe do seu gestor são de alta qualidade e assertivas, permitindo que você realize seu trabalho de forma eficaz?" },
            new Chefia { Descricao = "Você sente que seus gestores e os sócios ouvem atentamente suas opiniões e preocupações no ambiente de trabalho?" }
        );
    }
}
