using System;
using System.Collections.Generic;
using System.Data;
using ChoreHelper.WebApi.Chores;
using ChoreHelper.WebApi.Contributors;

namespace ChoreHelper.WebApi.Overdue
{
    public class OverdueChoreRepository : IOverdueChoreRepository
    {
        public IEnumerable<OverdueChore> Retrieve()
        {
            var results = new List<OverdueChore>();
            return results;
        }
    }
}
