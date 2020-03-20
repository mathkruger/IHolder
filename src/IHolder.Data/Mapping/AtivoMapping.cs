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
            builder.Property(a => a.Ticker)
                .HasColumnName("VARCHAR(50)")
                .IsRequired();
            builder.Property(r => r.Descricao)
                .IsRequired()
                .HasColumnType("VARCHAR(30)");
            builder.Property(r => r.Caracteristicas)
                .IsRequired()
                .HasColumnType("VARCHAR(240)");
            builder.HasMany(r => r.Distribuicoes_por_ativos)
                .WithOne(d => d.Ativo)
                .HasForeignKey(d => d.Ativo_id);
            builder.HasMany(r => r.Aportes)
                .WithOne(d => d.Ativo)
                .HasForeignKey(d => d.Ativo_id);
            builder.ToTable("Ativo");

        }
    }
}
