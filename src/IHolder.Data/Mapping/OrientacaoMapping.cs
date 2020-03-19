using IHolder.Business.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace IHolder.Data.Mapping
{
    public class OrientacaoMapping : IEntityTypeConfiguration<Orientacao>
    {
        public void Configure(EntityTypeBuilder<Orientacao> builder)
        {
            builder.HasKey(o => o.Id);
            builder.Property(o => o.Descricao)
                .IsRequired()
                .HasColumnType("VARCHAR(30)");
            builder.Property(o => o.Caracteristicas)
                .IsRequired()
                .HasColumnType("VARCHAR(240)");

            builder.HasMany(o => o.Distribuicoes_por_tipos_investimentos)
            .WithOne(d => d.Orientacao)
            .HasForeignKey(d => d.Orientacao_id);

            builder.HasMany(o => o.Distribuicoes_por_produtos)
            .WithOne(d => d.Orientacao)
            .HasForeignKey(d => d.Orientacao_id);

            builder.ToTable("ORIENTACAO");
        }
    }
}
