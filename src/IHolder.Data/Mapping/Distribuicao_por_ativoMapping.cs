using IHolder.Business.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace IHolder.Data.Mapping
{
    public class Distribuicao_por_ativoMapping : IEntityTypeConfiguration<Distribuicao_por_ativo>
    {
        public void Configure(EntityTypeBuilder<Distribuicao_por_ativo> builder)
        {
            builder.HasKey(d => d.Id);
            builder.ToTable("Distribuicao_por_ativo");
        }
    }
}
