using IHolder.Business.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace IHolder.Data.Mapping
{
    public class RiscoMapping : IEntityTypeConfiguration<Risco>
    {
        public void Configure(EntityTypeBuilder<Risco> builder)
        {
            builder.HasKey(r => r.Id);
            builder.Property(r => r.Descricao)
                .IsRequired()
                .HasColumnType("VARCHAR(30)");
            builder.Property(r => r.Caracteristicas)
                .IsRequired()
                .HasColumnType("VARCHAR(240)");

            builder.HasMany(r => r.Tipos_investimentos)
                .WithOne(t => t.Risco)
                .HasForeignKey(t => t.Risco_id);

            builder.ToTable("RISCO");
        }
    }
}
