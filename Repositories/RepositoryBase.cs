using StatlerWaldorfCorp.TeamService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StatlerWaldorfCorp.TeamService.Repositories
{
    public abstract class RepositoryBase<T> : IRepository<T> where T : class
    {
        
        void IRepository<T>.AddEntity(T entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<T>.DeleteEntity(T entity)
        {
            throw new NotImplementedException();
        }

        IQueryable<T> IRepository<T>.FindAll()
        {
            throw new NotImplementedException();
        }

        IEnumerable<T> IRepository<T>.GetAll()
        {
            throw new NotImplementedException();
        }

      
        void IRepository<T>.UdpateEntity(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
