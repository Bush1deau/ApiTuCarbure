
using ApiTuCarbure.EntityLayer;
using ApiTuCarbure.Interfaces;
using ApiTuCarbure.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiTuCarbure.RepositoryLayer
{ 

    public class StationRepository : IRepository<Station>
    {
        private readonly TuCarburesContext _context;

        public StationRepository(TuCarburesContext context)
        {
            _context = context;
        }

        public List<Station> Get()
        {
            return _context.Stations.Include("Brand").OrderBy(row => row.id_Station).ToList();
        }

        public Station? Get(int id)
        {
            return _context.Stations.Find(id);
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