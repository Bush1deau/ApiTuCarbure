using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiTuCarbure.EntityLayer;
using ApiTuCarbure.Interfaces;
using ApiTuCarbure.Models;

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
            return _context.Stations.OrderBy(row => row.id_Station).ToList();
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