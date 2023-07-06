using ApiTuCarbure.EntityLayer;
using ApiTuCarbure.Interfaces;
using ApiTuCarbure.Models;
using ApiTuCarbure.RepositoryLayer;
using Microsoft.AspNetCore.Mvc;
using static System.Collections.Specialized.BitVector32;

namespace ApiTuCarbure.Controllers;
[Route("api/[controller]")]
[ApiController]
public class StationController : ControllerBase
{
    private IRepository<Station> _repo;
    public StationController(IRepository<Station> repo)
    {
        _repo = repo;
    }


    [HttpGet]
    public List<Station> Get()
    {
        List<Station> list;

        list = _repo.Get();
        return list;
    }

    [HttpGet("{id}")]
    public Station? Get(int id)
    {
        Station? entity;

        entity = _repo.Get(id);

        return entity;
    }
}