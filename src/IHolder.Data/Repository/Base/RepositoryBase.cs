using IHolder.Business.Entities.Base;
using IHolder.Business.Repositories.Base;
using IHolder.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IHolder.Data.Repository.Base
{
    public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : Entidade_base, new()
    {
        protected readonly IHolderContext _context;
        protected readonly DbSet<TEntity> _dbSet;

        protected RepositoryBase(IHolderContext context)
        {
            this._context = context;
            _dbSet = context.Set<TEntity>();
        }

        public virtual async Task<IEnumerable<TEntity>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }
        public virtual async Task<TEntity> GetById(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<IEnumerable<TEntity>> GetManyBy(Expression<Func<TEntity, bool>> predicate)
        {
            return await _dbSet.AsNoTracking().Where(predicate).ToListAsync();
        }
        public virtual async Task<int> Insert(TEntity entity)
        {
            _dbSet.Add(entity);
            await SaveChanges();
            return entity.Id;
        }
        public virtual async Task<int> Update(TEntity entity)
        {
            _dbSet.Update(entity);
            return await SaveChanges();
        }
        public virtual async Task Delete(int id)
        {
            _dbSet.Remove(new TEntity { Id = id });
            await SaveChanges();
        }

        public async Task<int> SaveChanges()
        {
            return await _context.SaveChangesAsync();
        }
        public void Dispose()
        {
            _context?.Dispose();
        }

        public async Task<TEntity> GetBy(Expression<Func<TEntity, bool>> predicate)
        {
            return await _dbSet.AsNoTracking().Where(predicate).FirstOrDefaultAsync();
        }
    }
}
