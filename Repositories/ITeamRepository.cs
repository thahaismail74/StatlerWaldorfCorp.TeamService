using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StatlerWaldorfCorp.TeamService.Models;
namespace StatlerWaldorfCorp.TeamService.Repositories
{
    public interface IRepository<T>
    {
         IEnumerable<T> GetAll();
        void AddEntity(T entity);
        IQueryable<T> FindAll();
        void UdpateEntity(T entity);

        void DeleteEntity(T entity);


    }
}
