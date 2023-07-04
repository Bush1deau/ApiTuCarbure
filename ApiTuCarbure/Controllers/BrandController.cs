using ApiTuCarbure.EntityLayer;
using ApiTuCarbure.Interfaces;
using ApiTuCarbure.Models;
using ApiTuCarbure.RepositoryLayer;
using Microsoft.AspNetCore.Mvc;
using static System.Collections.Specialized.BitVector32;

namespace ApiTuCarbure.Controllers;
[Route("api/[controller]")]
[ApiController]
public class BrandController : ControllerBase
{
    private IRepositoryB<Brand> _repo;
    public BrandController(IRepositoryB<Brand> repo)
    {
        _repo = repo;
    }


    [HttpGet]
    public List<Brand> Get()
    {
        List<Brand> list;

        list = _repo.Get();
        return list;
    }

    [HttpGet("{id}")]
    public Brand Get(int id)
    {
        Brand entity;

        entity = _repo.Get(id);

        return entity;
    }
}