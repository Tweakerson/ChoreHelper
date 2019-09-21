using Microsoft.AspNetCore.Mvc;
using System;

namespace ChoreHelper.WebApi.ChoreEvents
{
    [Route("api/choreevent")]
    [ApiController]
    public class ChoreEventController : ControllerBase
    {
        private ChoreEventRepository repository;

        [HttpPost("")]
        public ActionResult<string> Save(int? choreId, int? contributorId, DateTime? date)
        {
            ChoreEvent choreEvent = new ChoreEvent()
            {
                ChoreId = choreId,
                ContributorId = contributorId,
                EventDate = date
            };

            repository = new ChoreEventRepository();
            repository.Insert(choreEvent);
            return Ok();
        }
    }
}