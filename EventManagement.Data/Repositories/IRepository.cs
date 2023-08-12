using EventManagement.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagement.Data.Repositories
{
    public interface IRepository<TEntity> where TEntity : IBaseEntity
    {
        IQueryable<TEntity> GetAll();
        TEntity FindById(int id);
        TEntity Add(TEntity entity);

        TEntity Update(TEntity entity);
    }
}
