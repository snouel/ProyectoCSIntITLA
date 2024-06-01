
using DBBoletoBus.Domain.Core;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DBBoletoBus.Infraestructure.Core
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly DbContext context;
        private DbSet<TEntity> _entities;

        protected BaseRepository(DbContext context)
        {
            this.context = context;
            this._entities = this.context.Set<TEntity>();
        }

        public async Task<bool> Exists(Expression<Func<TEntity, bool>> filter)
        { 
            return await this._entities.AnyAsync(filter);
        }

        public async Task<TEntity> Get(int Id)
        {
            return await _entities.FindAsync(Id);
        }

        public async Task<List<TEntity>> GetAll(Expression<Func<TEntity, bool>> filter)
        {
            return await _entities.Where(filter).ToListAsync();
        }

        public async Task Save(TEntity entity)
        {
            this._entities.Add(entity);
            await this.context.SaveChangesAsync();
        }

        public async Task Save(List<TEntity> entities)
        {
            this._entities.AddRange(entities);
            await this.context.SaveChangesAsync();
        }

        public async Task Update(TEntity entity)
        {
            this._entities.Update(entity);
            await this.context.SaveChangesAsync();
        }

        public async Task Update(List<TEntity> entities)
        {
            this._entities.UpdateRange(entities);
            await this.context.SaveChangesAsync();
        }
    }
}
