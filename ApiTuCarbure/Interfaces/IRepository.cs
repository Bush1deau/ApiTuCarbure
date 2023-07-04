using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTuCarbure.Interfaces
{
    public interface IRepository<T>
    {
        List<T> Get();
        T? Get(int id);
    }
    public interface IRepositoryS<Statement>
    {
        List<Statement> Get();
        Statement? Get(int id);
        Statement Insert(Statement entity);
    }

}