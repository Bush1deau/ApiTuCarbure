
using ApiTuCarbure.EntityLayer;
using ApiTuCarbure.Interfaces;
using ApiTuCarbure.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiTuCarbure.RepositoryLayer
{ 

    public class StatementRepository : IRepositoryS<Statement>
    {
        private readonly TuCarburesContext _context;

        public StatementRepository(TuCarburesContext context)
        {
            _context = context;
        }

        public List<Statement> Get()
        {
            return _context.Statements.Include("Station").Include("Fuel").OrderBy(row => row.id_Statement).ToList();
        }

        public Statement? Get(int id)
        {
            return _context.Statements.Include("Station").Include("Fuel").Where(s => s.id_Statement == id).FirstOrDefault();
        }

        public Statement Insert(Statement entity)
        {
            _context.Statements.Update(entity);

            _context.SaveChanges();

            return entity;
        }
    }
}