using System.Collections.Generic;
using System.Data;

namespace ChoreHelper.WebApi.Chores
{
    public class ChoreRepository : IChoreRepository
    {
        public IEnumerable<Chore> Retrieve()
        {
            List<Chore> results = new List<Chore>();

            return results;
        }
    }
}
