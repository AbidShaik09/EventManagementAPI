using EventManagement.Data.Entities;
using EventManagement.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagement.Data.UnitOfWork
{
    public interface IUnitOfWork
    {
        void Save();

        IRepository<User> Users { get; }

    }
}
