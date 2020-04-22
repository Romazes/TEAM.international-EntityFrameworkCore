using Microsoft.EntityFrameworkCore;
using Repository.Base;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EntityFramework.Abstract
{
    public abstract class Repository<TModel, TContext> : IRepository<TModel>
        where TModel : class
        where TContext : DbContext
    {
        private readonly TContext _context;

        public Repository(TContext context)
        {
            _context = context;
        }

        public async Task<TModel> Add(TModel entity)
        {
            _context.Set<TModel>().Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<TModel> Delete(int? id)
        {
            var entity = await _context.Set<TModel>().FindAsync(id);
            if (entity == null)
            {
                return entity;
            }

            _context.Set<TModel>().Remove(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task<TModel> Get(int? id)
        {
            return await _context.Set<TModel>().FindAsync(id);
        }

        public async Task<IEnumerable<TModel>> GetAll()
        {
            return await _context.Set<TModel>().ToListAsync();
        }

        public async Task<TModel> Update(TModel entity)
        {
            
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
