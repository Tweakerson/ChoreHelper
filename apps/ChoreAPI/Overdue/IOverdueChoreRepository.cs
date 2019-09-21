using System.Collections.Generic;

namespace ChoreHelper.WebApi.Overdue
{
    public interface IOverdueChoreRepository
    {
        IEnumerable<OverdueChore> Retrieve();
    }
}
