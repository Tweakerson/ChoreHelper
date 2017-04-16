using ChoreData;
using System.Collections.Generic;

namespace ChoreServices.Interface
{
    public interface IChoreService
    {
        Chore Save(Chore entity);

        IEnumerable<Chore> GetList();

        Chore GetRandomChore();
    }
}
