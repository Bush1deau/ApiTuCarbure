using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTuCarbure.Interfaces
{
    public interface IRepository<Station>
    {
        List<Station> Get();
        Station? Get(int id);
        //T Insert(T entity);
    }
}