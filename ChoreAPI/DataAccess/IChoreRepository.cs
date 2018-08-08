using ChoreData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoreDataAccess.Interface
{
    public interface IChoreRepository : IRepository<Chore>
    {
        Chore Get(int id);

        IEnumerable<Chore> GetList();

        Chore Save(Chore entity);
    }
}
