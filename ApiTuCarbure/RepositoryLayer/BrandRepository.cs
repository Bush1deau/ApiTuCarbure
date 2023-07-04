using ApiTuCarbure.EntityLayer;
using ApiTuCarbure.Interfaces;
using ApiTuCarbure.Models;

namespace ApiTuCarbure.RepositoryLayer
{
    public class BrandRepository : IRepository<Brand>
    {
        private readonly TuCarburesContext _context;

        public BrandRepository(TuCarburesContext context)
        {
            _context = context;
        }

        public List<Brand> Get()
        {
            return _context.Brands.OrderBy(row => row.id_Brand).ToList();
        }

        public Brand? Get(int id)
        {
            return _context.Brands.Find(id);
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