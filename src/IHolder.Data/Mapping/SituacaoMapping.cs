using IHolder.Business.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace IHolder.Data.Mapping
{
    public class SituacaoMapping : Informacoes_baseMapping<Situacao>
    {

        public override void Configure(EntityTypeBuilder<Situacao> builder)
        {
            base.Configure(builder);

            builder.HasMany(p => p.Situacoes_por_ativos)
            .WithOne(a => a.Situacao)
            .HasForeignKey(a => a.Situacao_id);

            builder.ToTable("Situacao");
        }
    }
}
