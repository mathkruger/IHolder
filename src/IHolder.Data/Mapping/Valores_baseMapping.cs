using IHolder.Business.Entities.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace IHolder.Data.Mapping
{
    public class Valores_baseMapping<T> : IEntityTypeConfiguration<T> where T : Valores_base
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(d => d.Id);
        }
    }
}
