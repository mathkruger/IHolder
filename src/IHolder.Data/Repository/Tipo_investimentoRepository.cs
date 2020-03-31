using IHolder.Business.Entities;
using IHolder.Business.Interfaces.Repositories;
using IHolder.Data.Context;
using IHolder.Data.Repository.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IHolder.Data.Repository
{
    public class Tipo_investimentoRepository : RepositoryBase<Tipo_investimento>, ITipo_investimentoRepository
    {
        public Tipo_investimentoRepository(IHolderContext context) : base(context)
        {
        }

        public  override async Task<IEnumerable<Tipo_investimento>> GetAll()
        {
            return await _dbSet.AsNoTracking().Include(p => p.Produtos).ToListAsync();
        }
    }
}
