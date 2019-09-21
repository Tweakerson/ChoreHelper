using ChoreHelper.WebApi.Chores;
using ChoreHelper.WebApi.Contributors;
using System;

namespace ChoreHelper.WebApi.Overdue
{
    public class OverdueChore 
    {
        public Chore Chore { get; set; }

        public Contributor Contributer { get; set; }

        public DateTime? EventDate { get; set; }

        public DateTime? ExpectedEventDate { get; set; }

        public int? OverdueDays { get; set; }
    }
}
