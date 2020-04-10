using IHolder.Business.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace IHolder.Data.Mapping
{
    public class OrientacaoMapping : Informacoes_baseMapping<Orientacao>
    {

        public override void Configure(EntityTypeBuilder<Orientacao> builder)
        {
            base.Configure(builder);
            builder.HasMany(o => o.Distribuicoes_por_tipos_investimentos)
            .WithOne(d => d.Orientacao)
            .HasForeignKey(d => d.Orientacao_id);

            builder.HasMany(o => o.Distribuicoes_por_produtos)
            .WithOne(d => d.Orientacao)
            .HasForeignKey(d => d.Orientacao_id);

            builder.HasMany(o => o.Distribuicoes_por_ativos)
            .WithOne(d => d.Orientacao)
            .HasForeignKey(d => d.Orientacao_id);

            builder.ToTable("Orientacao");
        }

    }
}
