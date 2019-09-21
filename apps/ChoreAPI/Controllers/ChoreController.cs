using ChoreData;
using ChoreDataAccess.Repositories;
using ChoreServices.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ChoreAPI.Controllers
{
    [RoutePrefix("api/chore")]
    public class ChoreController : ApiController
    {
        ChoreService service;
        
        [Route("getlist")]
        public IEnumerable<Chore> Get()
        {
            service = new ChoreService(new ChoreRepository());

            return service.GetList();
        }
        
        [Route("get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [Route("add")]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [Route("update")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [Route("delete")]
        public void Delete(int id)
        {
        }
    }
}
