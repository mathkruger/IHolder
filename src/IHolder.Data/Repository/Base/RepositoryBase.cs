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
        protected readonly IHolderContext Context;
        protected readonly DbSet<TEntity> DbSet;

        protected RepositoryBase(IHolderContext context)
        {
            this.Context = context;
            DbSet = context.Set<TEntity>();
        }

        public virtual async Task<IEnumerable<TEntity>> GetAll()
        {
            return await DbSet.ToListAsync();
        }
        public virtual async Task<TEntity> GetById(int id)
        {
            return await DbSet.FindAsync(id);
        }

        public async Task<IEnumerable<TEntity>> GetBy(Expression<Func<TEntity, bool>> predicate)
        {
            return await DbSet.AsNoTracking().Where(predicate).ToListAsync();
        }
        public virtual async Task<int> Insert(TEntity entity)
        {
            DbSet.Add(entity);
            return await SaveChanges();
        }
        public virtual async Task<int> Update(TEntity entity)
        {
            DbSet.Update(entity);
            return await SaveChanges();
        }
        public virtual async Task Delete(int id)
        {
            DbSet.Remove(new TEntity { Id = id });
            await SaveChanges();
        }

        public async Task<int> SaveChanges()
        {
            return await Context.SaveChangesAsync();
        }
        public void Dispose()
        {
            Context?.Dispose();
        }
    }
}
