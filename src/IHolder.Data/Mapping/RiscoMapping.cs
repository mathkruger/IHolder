using IHolder.Business.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace IHolder.Data.Mapping
{
    public class RiscoMapping : Informacoes_baseMapping<Risco>
    {

        public override void Configure(EntityTypeBuilder<Risco> builder)
        {
            base.Configure(builder);
            builder.HasMany(r => r.Tipos_investimentos)
                .WithOne(t => t.Risco)
                .HasForeignKey(t => t.Risco_id);

            builder.HasMany(r => r.Ativos)
                .WithOne(t => t.Risco)
                .HasForeignKey(t => t.Risco_id);

            builder.ToTable("Risco");
        }
    }
}
