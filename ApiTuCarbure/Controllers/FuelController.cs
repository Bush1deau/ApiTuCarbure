using ApiTuCarbure.EntityLayer;
using ApiTuCarbure.Interfaces;
using ApiTuCarbure.Models;
using ApiTuCarbure.RepositoryLayer;
using Microsoft.AspNetCore.Mvc;
using static System.Collections.Specialized.BitVector32;

namespace ApiTuCarbure.Controllers;
[Route("api/[controller]")]
[ApiController]
public class FuelController : ControllerBase
{
    private IRepository<Fuel> _repo;
    public FuelController(IRepository<Fuel> repo)
    {
        _repo = repo;
    }


    [HttpGet]
    public List<Fuel> Get()
    {
        List<Fuel> list;

        list = _repo.Get();
        return list;
    }

    [HttpGet("{id}")]
    public Fuel Get(int id)
    {
        Fuel entity;

        entity = _repo.Get(id);

        return entity;
    }
}