using System;
using System.Collections.Generic;
using System.Data;

namespace ChoreHelper.WebApi.ChoreEvents
{
    public class ChoreEventRepository
    {
        public IEnumerable<ChoreEvent> Retrieve()
        {
            List<ChoreEvent> results = new List<ChoreEvent>();

            return results;
        }

        public void Insert(ChoreEvent choreEvent)
        {
        }
    }
}
