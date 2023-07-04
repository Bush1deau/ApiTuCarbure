
using ApiTuCarbure.EntityLayer;
using ApiTuCarbure.Interfaces;
using ApiTuCarbure.Models;

namespace ApiTuCarbure.RepositoryLayer
{
    public class FuelRepository : IRepository<Fuel>
    {
        private readonly TuCarburesContext _context;

        public FuelRepository(TuCarburesContext context)
        {
            _context = context;
        }

        public List<Fuel> Get()
        {
            return _context.Fuels.OrderBy(row => row.id_Fuel).ToList();
        }

        public Fuel? Get(int id)
        {
            return _context.Fuels.Find(id);
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