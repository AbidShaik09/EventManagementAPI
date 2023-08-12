using EventManagement.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagement.Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly Context _context;
        private readonly DbSet<TEntity> entities;
        public Repository(Context context)
        {
            this._context = context;
            entities = context.Set<TEntity>();
        }

        public TEntity Add(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Enitity cannot be null");
            }

            _context.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public TEntity FindById(int id)
        {
            return entities.FirstOrDefault(x => x.Id == id);
        }

        public IQueryable<TEntity> GetAll()
        {
            return entities.AsQueryable();
        }

        public TEntity Update(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException($"{nameof(entity)} entity must not be null");
            }
            try
            {
                _context.Update(entity);
                _context.SaveChangesAsync();
                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception($"{nameof(entity)} could not be updated: {ex.Message}");
            }
        }
    }
}
