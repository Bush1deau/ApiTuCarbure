
using ApiTuCarbure.EntityLayer;
using ApiTuCarbure.Interfaces;
using ApiTuCarbure.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiTuCarbure.RepositoryLayer
{ 

    public class StationFuelRepository : IRepository<StationFuel>
    {
        private readonly TuCarburesContext _context;

        public StationFuelRepository(TuCarburesContext context)
        {
            _context = context;
        }

        public List<StationFuel> Get()
        {
            return _context.StationFuels.Include("Station").Include("Fuel").ToList();
        }

        public StationFuel? Get(int id)
        {
            return _context.StationFuels.Find(id);
        }
    }
}