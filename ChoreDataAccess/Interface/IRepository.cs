using ChoreData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoreDataAccess.Interface
{
    public interface IRepository
    {
        EntityBase Get(int id);

        IEnumerable<EntityBase> GetList();

        EntityBase Save(EntityBase entity);
    }
}
