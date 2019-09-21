using Microsoft.AspNetCore.Mvc;

namespace ChoreHelper.WebApi.Overdue
{
    [Route("api/overduechore")]
    [ApiController]
    public class OverdueChoreController : ControllerBase
    {
        private OverdueChoreRepository repository;

        [HttpGet("")]
        public ActionResult<string> Get()
        {
            repository = new OverdueChoreRepository();
            var results = repository.Retrieve();
            return Ok(results);
        }
    }
}