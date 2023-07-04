using ApiTuCarbure.EntityLayer;
using ApiTuCarbure.Interfaces;
using ApiTuCarbure.Models;
using ApiTuCarbure.RepositoryLayer;
using Microsoft.AspNetCore.Mvc;
using static System.Collections.Specialized.BitVector32;

namespace ApiTuCarbure.Controllers;
[Route("api/[controller]")]
[ApiController]
public class StatementController : ControllerBase
{
    private IRepository<Statement> _repo;
    public StatementController(IRepository<Statement> repo)
    {
        _repo = repo;
    }


    [HttpGet]
    public List<Statement> Get()
    {
        List<Statement> list;

        list = _repo.Get();
        return list;
    }

    [HttpGet("{id}")]
    public Statement Get(int id)
    {
        Statement entity;

        entity = _repo.Get(id);

        return entity;
    }
}