using IHolder.Business.Entities.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace IHolder.Data.Mapping
{
    public class Informacoes_baseMapping<T> : IEntityTypeConfiguration<T> where T : Informacoes_base
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(r => r.Descricao).IsRequired().HasColumnType("VARCHAR(30)");
            builder.Property(r => r.Caracteristicas).IsRequired().HasColumnType("VARCHAR(240)");
        }
    }
}
