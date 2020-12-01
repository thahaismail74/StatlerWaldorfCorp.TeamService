using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StatlerWaldorfCorp.TeamService.Models;

namespace StatlerWaldorfCorp.TeamService.Repositories
{
    public class MemoryTeamRepository : IRepository<Team>
    {
        protected ICollection<Team> _teamList;

        public MemoryTeamRepository()
         {
            if ( _teamList == null)
            {
                _teamList = new List<Team>();
            }

        }
        public  void AddTeam(Team myTeam)
        {
            _teamList.Add(myTeam);

        }

        public  IQueryable<Team> GetAll()
        {
           return (IQueryable<Team>)_teamList;
        }

        void IRepository<Team>.AddEntity(Team entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Team>.DeleteEntity(Team entity)
        {
            throw new NotImplementedException();
        }

        IQueryable<Team> IRepository<Team>.FindAll()
        {
            throw new NotImplementedException();
        }

        IEnumerable<Team> IRepository<Team>.GetAll()
        {
            throw new NotImplementedException();
        }

        void IRepository<Team>.UdpateEntity(Team entity)
        {
            throw new NotImplementedException();
        }
    }
}
