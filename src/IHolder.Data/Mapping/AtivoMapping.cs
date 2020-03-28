using IHolder.Business.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace IHolder.Data.Mapping
{
    public class AtivoMapping : IEntityTypeConfiguration<Ativo>
    {
        public void Configure(EntityTypeBuilder<Ativo> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Ticker).HasColumnType("VARCHAR(50)").IsRequired();
            builder.Property(a => a.Cotacao).IsRequired();
            builder.Property(a => a.Risco_id).IsRequired();
            builder.Property(a => a.Produto_id).IsRequired();
            builder.Property(r => r.Descricao).IsRequired().HasColumnType("VARCHAR(30)");
            builder.Property(r => r.Caracteristicas).IsRequired().HasColumnType("VARCHAR(240)");
            builder.Property(p => p.Data_inclusao).IsRequired();
            builder.Property(p => p.Usuario_id).IsRequired();
            builder.HasMany(r => r.Distribuicoes_por_ativos).WithOne(d => d.Ativo).HasForeignKey(d => d.Ativo_id);
            builder.HasMany(r => r.Aportes).WithOne(d => d.Ativo).HasForeignKey(d => d.Ativo_id);
            builder.HasMany(r => r.Situacoes_por_ativos).WithOne(d => d.Ativo).HasForeignKey(d => d.Ativo_id);
            builder.ToTable("Ativo");

        }
    }
}
