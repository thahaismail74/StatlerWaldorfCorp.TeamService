using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StatlerWaldorfCorp.TeamService.Models;
using StatlerWaldorfCorp.TeamService.Repositories;
namespace StatlerWaldorfCorp.TeamService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
        IRepository<Team> _teamRepository;

        public TeamsController(IRepository<Team> repo)
        {
            _teamRepository = repo;
        }
        //[HttpGet]
        //public IEnumerable<Team> GetAllTeams()
        //{

        //  //  return Enumerable.Empty<Team>();

        //    return new Team[] { new Team("one"), new Team("two") };

        //}

        [HttpGet]
        public  virtual IEnumerable<Team>  GetAll()
        {
            return _teamRepository.GetAll();
        }

        [HttpPost]

        public  void AddTeams( Team myTeam)
        {
             _teamRepository.AddEntity(myTeam);
        }

    }
}
