using IHolder.Business.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace IHolder.Data.Mapping
{
    public class Tipo_investimentoMapping : IEntityTypeConfiguration<Tipo_investimento>
    {
        public void Configure(EntityTypeBuilder<Tipo_investimento> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Descricao)
                .IsRequired()
                .HasColumnType("VARCHAR(30)");
            builder.Property(t => t.Caracteristicas)
                .IsRequired()
                .HasColumnType("VARCHAR(240)");



            builder.HasMany(t => t.Distribuicoes_por_tipos_investimentos)
                .WithOne(d => d.Tipo_investimento)
                .HasForeignKey(t => t.Tipo_investimento_id);

            builder.HasMany(t => t.Produtos)
                .WithOne(p => p.Tipo_investimento)
                .HasForeignKey(p => p.Tipo_investimento_id);


            builder.ToTable("TIPO_INVESTIMENTO");
        }
    }
}
