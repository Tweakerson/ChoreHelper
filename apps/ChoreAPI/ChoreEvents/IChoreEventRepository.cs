using System.Collections.Generic;

namespace ChoreHelper.WebApi.ChoreEvents
{
    public interface IChoreEventRepository
    {
        IEnumerable<ChoreEvent> Retrieve();

        void Insert(ChoreEvent choreEvent);
    }
}
