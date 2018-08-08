using ChoreData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoreDataAccess.Interface
{
    public interface IChoreEventRepository : IRepository<ChoreEvent>
    {
        ChoreEvent Get(int id);

        IEnumerable<ChoreEvent> GetList();

        ChoreEvent Save(ChoreEvent entity);
    }
}
