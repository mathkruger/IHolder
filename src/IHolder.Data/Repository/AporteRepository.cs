using IHolder.Business.Entities;
using IHolder.Business.Interfaces.Repositories;
using IHolder.Data.Context;
using IHolder.Data.Repository.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace IHolder.Data.Repository
{
    public class AporteRepository : RepositoryBase<Aporte>, IAporteRepository
    {
        public AporteRepository(IHolderContext context) : base(context)
        {
        }
    }
}
