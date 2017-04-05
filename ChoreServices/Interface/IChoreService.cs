using ChoreData;
using System.Collections.Generic;

namespace ChoreServices.Interface
{
    public interface IChoreService
    {
        EntityBase Save(EntityBase entity);

        IEnumerable<EntityBase> GetList();

        EntityBase GetRandomChore();
    }
}
