using ChoreData;
using System.Collections.Generic;

namespace ChoreServices.Interface
{
    public interface IChoreEventService
    {
        ChoreEvent Save(ChoreEvent entity);

        IEnumerable<ChoreEvent> GetList();

        ChoreEvent GetRandomChore();
    }
}
