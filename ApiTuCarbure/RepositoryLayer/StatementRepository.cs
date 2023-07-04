
using ApiTuCarbure.EntityLayer;
using ApiTuCarbure.Interfaces;
using ApiTuCarbure.Models;

namespace ApiTuCarbure.RepositoryLayer
{ 

    public class StatementRepository : IRepository<Statement>
    {
        private readonly TuCarburesContext _context;

        public StatementRepository(TuCarburesContext context)
        {
            _context = context;
        }

        public List<Statement> Get()
        {
            return _context.Statements.OrderBy(row => row.id_Statement).ToList();
        }

        public Statement? Get(int id)
        {
            return _context.Statements.Find(id);
        }

        //   public Station Insert(Station entity)
        //   {
        //     entity.ModifiedDate = DateTime.Now;
        //     entity.Rowguid = Guid.NewGuid();

        //     _context.Stations.Add(entity);

        //     _context.SaveChanges();

        //     return entity;
        //     }
    }
}