using ApiTuCarbure.EntityLayer;
using ApiTuCarbure.Interfaces;
using ApiTuCarbure.Models;
using ApiTuCarbure.RepositoryLayer;
using Microsoft.AspNetCore.Mvc;
using static System.Collections.Specialized.BitVector32;

namespace ApiTuCarbure.Controllers;
[Route("api/[controller]")]
[ApiController]
public class StationFuelController : ControllerBase
{
    private IRepository<StationFuel> _repo;
    public StationFuelController(IRepository<StationFuel> repo)
    {
        _repo = repo;
    }


    [HttpGet]
    public List<StationFuel> Get()
    {
        List<StationFuel> list;

        list = _repo.Get();
        return list;
    }

    [HttpGet("{id}")]
    public StationFuel? Get(int id)
    {
        StationFuel? entity;

        entity = _repo.Get(id);

        return entity;
    }
}