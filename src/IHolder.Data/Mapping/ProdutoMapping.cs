using IHolder.Business.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace IHolder.Data.Mapping
{
    public class ProdutoMapping : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Descricao)
            .IsRequired()
            .HasColumnType("VARCHAR(30)");
            builder.Property(p => p.Caracteristicas)
            .IsRequired()
            .HasColumnType("VARCHAR(240)");

            builder.HasMany(p => p.Distribuicoes_por_produtos)
               .WithOne(d => d.Produto)
               .HasForeignKey(d => d.Produto_id);

            builder.ToTable("PRODUTO");


        }
    }
}
