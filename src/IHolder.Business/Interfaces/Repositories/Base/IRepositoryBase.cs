using IHolder.Business.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IHolder.Business.Repositories.Base
{
    public interface IRepositoryBase<TEntity> : IDisposable where TEntity : Entidade_base
    {
        Task<int> Insert(TEntity entity);
        Task<int> Update(TEntity entity);
        Task Delete(int id);
        Task<TEntity> GetById(int id);
        Task<IEnumerable<TEntity>> GetAll();
        Task<IEnumerable<TEntity>> GetBy(Expression<Func<TEntity, bool>> predicate);
        Task<int> SaveChanges();

    }
}
