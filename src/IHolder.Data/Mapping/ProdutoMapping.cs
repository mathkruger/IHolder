using IHolder.Business.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace IHolder.Data.Mapping
{
    public class ProdutoMapping : Informacoes_baseMapping<Produto>
    {

        public override void Configure(EntityTypeBuilder<Produto> builder)
        {
            base.Configure(builder);
            builder.Property(d => d.Tipo_investimento_id).IsRequired();

            builder.HasMany(p => p.Distribuicoes_por_produtos)
               .WithOne(d => d.Produto)
               .HasForeignKey(d => d.Produto_id);

            builder.HasMany(p => p.Ativos)
                .WithOne(a => a.Produto)
                .HasForeignKey(a => a.Produto_id);

            builder.ToTable("Produto");
        }
    }
}
