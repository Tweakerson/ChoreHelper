using System;

namespace ChoreHelper.WebApi.ChoreEvents
{
    public class ChoreEvent
    {
        public int? Id { get; set; }

        public int? ChoreId { get; set; }

        public int? ContributorId { get; set; }

        public DateTime? EventDate { get; set; }
    }
}
