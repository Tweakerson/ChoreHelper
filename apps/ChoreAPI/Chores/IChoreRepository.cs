using System.Collections.Generic;

namespace ChoreHelper.WebApi.Chores
{
    public interface IChoreRepository
    {
        IEnumerable<Chore> Retrieve();
    }
}
