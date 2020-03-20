using IHolder.Business.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace IHolder.Data.Mapping
{
    public class Distribuicao_por_tipo_investimentoMapping : IEntityTypeConfiguration<Distribuicao_por_tipo_investimento>
    {
        public void Configure(EntityTypeBuilder<Distribuicao_por_tipo_investimento> builder)
        {
            builder.HasKey(d => d.Id);

            builder.HasMany(d => d.Distribuicoes_por_produtos)
                .WithOne(p => p.Distribuicao_por_tipo_investimento)
                .HasForeignKey(p => p.Distribuicao_por_tipo_investimento_id);

            builder.ToTable("Distribuicao_por_tipo_investimento");

        }
    }
}
