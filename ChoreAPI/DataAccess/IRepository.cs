using ChoreData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoreDataAccess.Interface
{
    public interface IRepository<T> where T : EntityBase
    {
        T Get(int id);

        IEnumerable<T> GetList();

        T Save(T entity);
    }
}
