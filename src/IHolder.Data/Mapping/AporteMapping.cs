using IHolder.Business.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace IHolder.Data.Mapping
{
    public class AporteMapping : IEntityTypeConfiguration<Aporte>
    {
        public void Configure(EntityTypeBuilder<Aporte> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(p => p.Ativo_id).IsRequired();
            builder.Property(p => p.Preco_medio).IsRequired();
            builder.Property(p => p.Quantidade).IsRequired();
            builder.Property(p => p.Usuario_id).IsRequired();
            builder.Property(p => p.Data_inclusao).IsRequired();
            builder.Property(p => p.Data_aporte).IsRequired();
            builder.ToTable("Aporte");

        }
    }
}
