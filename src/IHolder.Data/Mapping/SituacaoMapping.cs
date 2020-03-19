using IHolder.Business.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace IHolder.Data.Mapping
{
    public class SituacaoMapping : IEntityTypeConfiguration<Situacao>
    {
        public void Configure(EntityTypeBuilder<Situacao> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Descricao)
                .IsRequired()
                .HasColumnType("VARCHAR(30)");
            builder.Property(p => p.Caracteristicas)
                .IsRequired()
                .HasColumnType("VARCHAR(240)");

            builder.ToTable("SITUACAO");
        }
    }
}
