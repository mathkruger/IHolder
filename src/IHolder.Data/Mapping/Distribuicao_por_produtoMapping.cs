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
        public void Configure(EntityTypeBuilder<Distribuicao_por_produto> builder)
        {
            builder.HasKey(d => d.Id);
            builder.ToTable("DISTRIBUICAO_POR_PRODUTO");
        }
    }
}
