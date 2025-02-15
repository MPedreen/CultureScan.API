using CultureScan.Domain.Perguntas;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace CultureScan.Infra.Repositories.Configurations.Perguntas;

public class ComunicacaoConfiguration : IEntityTypeConfiguration<Comunicacao>
{
    public void Configure(EntityTypeBuilder<Comunicacao> comunicacoes)
    {
        comunicacoes.HasKey(c => c.Id);

        comunicacoes.Property(c => c.Descricao)
            .IsRequired();

        comunicacoes.HasData(
            new Comunicacao { Descricao = "Você tem uma compreensão clara dos objetivos da sua área e de como eles se alinham aos objetivos gerais da empresa?" },
            new Comunicacao { Descricao = "As suas responsabilidades no cargo que ocupa estão bem definidas e são claras para você?" },
            new Comunicacao { Descricao = "Você sente que tem liberdade e oportunidades para dar sugestões e fazer críticas construtivas dentro do seu setor?" },
            new Comunicacao { Descricao = "Como você avalia a comunicação com sua chefia e com os demais gestores da empresa?" },
            new Comunicacao { Descricao = "Você considera que a comunicação entre os diferentes setores da empresa é eficiente e eficaz?" },
            new Comunicacao { Descricao = "Você tem confiança nos planos estratégicos, nas decisões e na direção que a empresa está tomando?" },
            new Comunicacao { Descricao = "Você confia que a empresa adota práticas éticas e transparentes em suas operações e decisões?" },
            new Comunicacao { Descricao = "Você sente que tem oportunidades suficientes para sugerir melhorias nos processos ou identificar novas oportunidades de negócios dentro da empresa?" },
            new Comunicacao { Descricao = "Você se sente tratado com respeito e de forma justa pelos gestores da empresa?" },
            new Comunicacao { Descricao = "O código de conduta da empresa está claro para você e é respeitado nos relacionamentos internos?" },
            new Comunicacao { Descricao = "Você considera que os comunicados internos da empresa são eficazes para manter todos os colaboradores bem informados?" },
            new Comunicacao { Descricao = "Como você avalia o relacionamento interno entre os colaboradores da empresa? Há um ambiente de cooperação?" }
        );
    }
}
