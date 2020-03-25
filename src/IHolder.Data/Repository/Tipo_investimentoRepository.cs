using IHolder.Business.Entities;
using IHolder.Business.Interfaces.Repositories;
using IHolder.Data.Context;
using IHolder.Data.Repository.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace IHolder.Data.Repository
{
    public class Tipo_investimentoRepository : RepositoryBase<Tipo_investimento>, ITipo_investimentoRepository
    {
        public Tipo_investimentoRepository(IHolderContext context) : base(context)
        {
        }
    }
}
