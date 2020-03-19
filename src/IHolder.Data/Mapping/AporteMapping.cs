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
            throw new NotImplementedException();
        }
    }
}
