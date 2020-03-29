using IHolder.Business.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IHolder.Business.Interfaces.Services.Base
{
#warning renaming 
    public interface IServiceGetBy<TEntity> where TEntity : Entidade_base
    {
        Task<TEntity> GetBy(Expression<Func<TEntity, bool>> predicate);
    }
}


