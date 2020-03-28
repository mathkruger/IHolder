using IHolder.Business.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace IHolder.Data.Mapping
{
    public class Distribuicao_por_produtoMapping : IEntityTypeConfiguration<Distribuicao_por_produto>
    {
        public Usuario Usuario { get; set; }
        public void Configure(EntityTypeBuilder<Distribuicao_por_produto> builder)
        {
            builder.HasKey(d => d.Id);
            builder.Property(p => p.Data_inclusao).IsRequired();
            builder.Property(p => p.Distribuicao_por_tipo_investimento_id).IsRequired();
            builder.Property(p => p.Produto_id).IsRequired();
            builder.Property(p => p.Orientacao_id).IsRequired();
            builder.Property(p => p.Usuario_id).IsRequired();
            builder.ToTable("Distribuicao_por_produto");
        }
    }
}
