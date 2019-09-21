using Microsoft.AspNetCore.Mvc;
using System;

namespace ChoreHelper.WebApi.Chores
{
    [Route("api/chore")]
    [ApiController]
    public class ChoreController : ControllerBase
    {
        private ChoreRepository repository;

        [HttpGet("")]
        public ActionResult<string> Get()
        {
            repository = new ChoreRepository();
            var results = repository.Retrieve();
            return Ok(results);
        }
    }
}